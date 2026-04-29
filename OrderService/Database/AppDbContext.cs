using Microsoft.EntityFrameworkCore;
using OrderService.Models;

namespace OrderService.Database;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<User> Users => Set<User>();
    public DbSet<Service> Services => Set<Service>();
    public DbSet<Order> Orders => Set<Order>();
    public DbSet<Invoice> Invoices => Set<Invoice>();
    public DbSet<EscrowAccount> EscrowAccounts => Set<EscrowAccount>();
    public DbSet<Dispute> Disputes => Set<Dispute>();
    public DbSet<Rating> Ratings => Set<Rating>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // contoh constraint penting
        modelBuilder.Entity<Rating>()
            .ToTable(t => t.HasCheckConstraint(
                "CK_Rating_Score",
                "[Score] >= 1 AND [Score] <= 5"
            ));

        modelBuilder.Entity<Order>()
            .Property(x => x.DestinationLocation)
            .HasColumnType("geography");

        modelBuilder.Entity<Order>()
            .Property(x => x.WaypointLocation)
            .HasColumnType("geography");
    }
}




