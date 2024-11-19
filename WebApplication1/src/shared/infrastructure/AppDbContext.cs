using Microsoft.EntityFrameworkCore;
using WebApplication1.idol.domain;

namespace WebApplication1.shared.infrastructure;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
 public DbSet<Idol> Idols { get; init; }

 protected override void OnModelCreating(ModelBuilder modelBuilder)
 {
  modelBuilder.Entity<Idol>(entity =>
  {
   entity.HasKey(e => e.Id);
   entity.Property(e => e.Name).IsRequired();
   entity.Property(e => e.RealName).IsRequired();
   entity.Property(e => e.Photo).IsRequired();
  });
 }
}
