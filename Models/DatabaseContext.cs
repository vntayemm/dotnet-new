namespace gorillaspace.Models
{
    using gorillaspace.Models;
    using Microsoft.EntityFrameworkCore;

    public class DatabaseContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        public int TenantId { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) :base(options)
        { }
        
        public DatabaseContext()
        {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Model config
            DatabaseConfiguration.Configure(modelBuilder);
            DatabaseConfiguration.TenantConfig(modelBuilder, TenantId);

            //Install seed first
            // Database.(new DatabaseInitializer());
        }
    }
}