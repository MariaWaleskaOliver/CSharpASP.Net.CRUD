using Microsoft.EntityFrameworkCore;

namespace InventoryApp.Entities
{
    public class InventoryDbContext : DbContext
    {
        public InventoryDbContext(DbContextOptions<InventoryDbContext> options)
            : base(options)
        {
        }

        // Add your properties for accessing your entities here...

        public DbSet<Inventory> Inventories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // Do your initializing/seeding here...
            _ = modelBuilder.Entity<Inventory>().HasData(
                new Inventory() { InventoryId = 1, DataOfInventory = DateTime.Parse("2015-12-04"), ProductContent = "Calander New Generation",Quantity = 10 },
                new Inventory() { InventoryId = 2, DataOfInventory = DateTime.Parse("2020-10-05"), ProductContent = "Pencil MultiColor ", Quantity = 7 }
                );
        }
    }
}
