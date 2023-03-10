using Microsoft.EntityFrameworkCore;

namespace Salon.Models
{
  public class SalonContext : DbContext
  {
    public DbSet<Stylist> Stylists { get; set; }
    public DbSet<Customer> Customers { get; set; }

    public SalonContext(DbContextOptions options) : base(options) { }
  }
}