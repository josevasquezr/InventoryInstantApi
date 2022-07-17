using Models;
using Microsoft.EntityFrameworkCore;

namespace Contexts
{
    public class InventoryContext : DbContext
    {
        public DbSet<Category> Categories => Set<Category>();
        public DbSet<Product> Products => Set<Product>();
        public DbSet<Warehouse> Warehouses => Set<Warehouse>();
        public DbSet<Storage> Storages => Set<Storage>();
        public DbSet<InputOutput> InOuts => Set<InputOutput>();

        public InventoryContext(DbContextOptions<InventoryContext> options) : base(options) { }
    }
}
