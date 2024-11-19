using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using WebApplication1.group;
using WebApplication1.idol;

namespace WebApplication1.shared.infrastructure;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
 public DbSet<Idol> Idols { get; init; }
 public DbSet<Group> Groups { get; init; }

 protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
 {
  optionsBuilder.ConfigureWarnings(warnings =>
   warnings.Ignore(RelationalEventId.PendingModelChangesWarning));

  base.OnConfiguring(optionsBuilder);
 }

 protected override void OnModelCreating(ModelBuilder modelBuilder)
 {
  var aespaId = Guid.NewGuid();

  modelBuilder.Entity<Group>(entity =>
  {
   entity.HasKey(e => e.Id);
   entity.Property(e => e.Name).IsRequired();
   entity.Property(e => e.Description).IsRequired();
   entity.Property(e => e.Photo).IsRequired();

   entity.HasData(new Group(
    Id: aespaId,
    Name: "aespa",
    Description: "aespa is a 4-member girl group (Karina, Giselle, Winter, Ningning) from SM Entertainment that debuted on Nov 17th, 2020 with \"Black Mamba.\"\n\nLargely thought to be one of the groups that “started the 4th gen of K-Pop,” aespa is recognized for their theme of AIs and virtual reality. Throughout their album art, lyrics, music videos, and concept films, aespa has established unique lore of their own, drawing inspiration from sub-culture genres such as cyberpunk and frutiger aero, reminiscent of the Y2K trend.\n\naespa’s discography spans a variety of genres - including electronica, synthpop, hyperpop, trap, hiphop, R&B, and more.",
    Photo: "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/GNEEkD4bgAASBoV.jpg"
   ));
  });


  modelBuilder.Entity<Idol>(entity =>
  {
   entity.HasKey(e => e.Id);
   entity.HasOne<Group>()
    .WithMany()
    .HasForeignKey(e => e.GroupId);
   entity.Property(e => e.Name).IsRequired();
   entity.Property(e => e.RealName).IsRequired();
   entity.Property(e => e.Photo).IsRequired();

   entity.HasData(
     new Idol(
      Id: Guid.NewGuid(),
      GroupId: aespaId,
      Name: "Karina",
      RealName: "Yoo Ji-min",
      Photo: "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/krn.jpeg"
      ),
     new Idol(
      Id: Guid.NewGuid(),
      GroupId: aespaId,
      Name: "Giselle",
      RealName: "Aeri Uchinaga",
      Photo: "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/gs.jpeg"
      ),
     new Idol(
      Id: Guid.NewGuid(),
      GroupId: aespaId,
      Name: "Winter",
      RealName: "Kim Min-jeong",
      Photo: "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/wt.jpeg"
      ),
     new Idol(
      Id: Guid.NewGuid(),
      GroupId: aespaId,
      Name: "Ningning",
      RealName: "Níng Yìzhuó",
      Photo: "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/nn.jpeg"
      )
    );
  });
 }
}
