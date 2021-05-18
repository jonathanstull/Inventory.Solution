using System;

namespace RocksInventory.Models
{
  public class Rock
  {
    public int RockId { get; set; }
    public string Description { get; set; }
    public string Classification { get; set; }
    public int Hardness { get; set; }
    public string Color { get; set; }
    public DateTime Acquired { get; set; }
  }
}