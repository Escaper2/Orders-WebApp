using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
    {
        Database.EnsureCreated();
    }

    public DbSet<Order> Orders { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Order>(builder =>
        {
            builder.Property(x => x.SenderLocation).HasMaxLength(250).IsRequired();
            builder.Property(x => x.SenderCity).HasMaxLength(100).IsRequired();
            builder.Property(x => x.RecipientLocation).HasMaxLength(250).IsRequired();
            builder.Property(x => x.RecipientCity).HasMaxLength(100).IsRequired();
            builder.Property(x => x.PickupDate).IsRequired();
            builder.Property(x => x.OrderId).IsRequired();
            builder.Property(x => x.LoadWeight).IsRequired();
        });
    }
}