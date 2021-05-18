using Microsoft.EntityFrameworkCore;

namespace RocksInventory.Models
{
  public class RocksInventoryContext : DbContext
  {
    public DbSet<Rock> Items { get; set; }

    public RocksInventoryContext(DbContextOptions options) : base(options) { }
  }
}