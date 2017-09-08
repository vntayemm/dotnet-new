namespace gorillaspace.Models
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata;
    using Microsoft.EntityFrameworkCore.Metadata.Internal;

    public class DatabaseConfiguration
    {
        public static void Configure(ModelBuilder modelBuilder)
        {
            modelBuilder.RemovePluralizingTableNameConvention();
        }

        public static void TenantConfig(ModelBuilder modelBuilder, int tenantId)
        {
            modelBuilder.Entity<Blog>()
                .HasQueryFilter(p => !p.IsDeleted &&
                    p.TenantId == tenantId);
        }
    }

    public class TenantModel
    {
        public int TenantId { get; set; }
        public bool IsDeleted { get; set; }

    }

    public static class ModelBuilderExtensions
    {
        public static void RemovePluralizingTableNameConvention(this ModelBuilder modelBuilder)
        {
            foreach (IMutableEntityType entity in modelBuilder.Model.GetEntityTypes())
            {
                // // Skip shadow types
                // if (entity.ClrType == null)
                //     continue;

                // entity.Relational().TableName = entity.ClrType.Name;

                entity.Relational().TableName = entity.DisplayName();
            }
        }
    }
}