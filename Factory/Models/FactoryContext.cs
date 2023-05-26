using Microsoft.EntityFrameworkCore;

namespace Factory.Models
{
  public class FactoryContext : DbContext
  {
    public DbSet<Engineer> Engineer { get; set; }
    public DbSet<Machine> Machine { get; set; }

    public FactoryContext(DbContextOptions options) : base(options) { }
  }
}