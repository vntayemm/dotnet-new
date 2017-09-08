namespace gorillaspace.Models
{
    using gorillaspace.Models;
    using Microsoft.EntityFrameworkCore;

    public class DatabaseContext : DbContext
    {
        public DbSet<ToDoItem> ToDoItems { get; set; }
        public int TenantId { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Model config
            DatabaseConfiguration.Configure(modelBuilder);
            DatabaseConfiguration.ToDoItemConfig(modelBuilder, TenantId);

            //Install seed first
            Database.(new DatabaseInitializer());
        }
    }
}