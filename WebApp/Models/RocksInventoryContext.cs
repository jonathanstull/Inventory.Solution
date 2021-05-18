using Microsoft.EntityFrameworkCore;

namespace RocksInventory.Models
{
  public class RocksInventoryContext : DbContext
  {
    public DbSet<Rock> Rocks { get; set; }

    public RocksInventoryContext(DbContextOptions options) : base(options) { }
  }
}