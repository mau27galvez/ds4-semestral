using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using WebApplication1.comment;
using WebApplication1.group;
using WebApplication1.idol;
using WebApplication1.user;

namespace WebApplication1.shared.infrastructure;

public class AppDbContext(DbContextOptions<AppDbContext> options) : IdentityDbContext<User, IdentityRole<Guid>, Guid>(options)
{
 public DbSet<Idol> Idols { get; init; }
 public DbSet<Group> Groups { get; init; }
 public DbSet<Comment> Comments { get; init; }

 protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
 {
  optionsBuilder.ConfigureWarnings(warnings =>
   warnings.Ignore(RelationalEventId.PendingModelChangesWarning));

  base.OnConfiguring(optionsBuilder);
 }

 protected override void OnModelCreating(ModelBuilder modelBuilder)
 {
  base.OnModelCreating(modelBuilder);

  modelBuilder.Entity<User>(entity =>
  {
   entity.Property(e => e.Initials).HasMaxLength(5);
  });

  modelBuilder.HasDefaultSchema("identity");

  var aespaId = Guid.NewGuid();
  var newJeansId = Guid.NewGuid();

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
   ),
    new Group(
     Id: newJeansId,
     Name: "New Jeans",
     Description: "NewJeans is a 5-member girl group (Minji, Hanni, Danielle, Haerin, Hyein) from ADOR that debuted on July 22nd, 2022 with “Attention.” \n\nOne of the most successful groups of the 4th generation of K-Pop, NewJeans is thought to have brought back the “easy listening” genre back to K-Pop, as well as popularizing the visual trend of the “girl next door” and “y2k concept” in the industry. NewJeans is known for their “natural” image; choosing minimalism over maximalism, or the typical level of “hyperproduction” in K-Pop. Super high notes, frantic beat changes, punchy rap verses, and super-synchronized dance routines are mostly absent from NewJeans’ hits.\n\nNewJeans is also loved for their “nostalgic” image and sound, blending mellow mid-tempo pop and R&B sounds with Jersey Club or Balitimore Club genre. Their overall concept has been called reminiscent of groups such as S.E.S, SPEED, and TLC.\n\nNewJeans is considered to be one of the major fashion icons in the K-Pop industry, with their signature “natural” look with minimal makeup and straight black hair which eventually branched out to other trends like balletcore and blokecore, coupled with collaborations with many fashion/beauty brands.",
     Photo: "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/newjeans.jpeg"
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
    ),
    new Idol(
     Id: Guid.NewGuid(),
     GroupId: newJeansId,
     Name: "Minji",
     RealName: "Kim Min-ji",
     Photo: "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/NJ_HowSweet_21.jpg"
    ),
    new Idol(
     Id: Guid.NewGuid(),
     GroupId: newJeansId,
     Name: "Hanni",
     RealName: "Hanni Pham",
     Photo: "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/NJ_HowSweet_19.jpg"
    ),
    new Idol(
     Id: Guid.NewGuid(),
     GroupId: newJeansId,
     Name: "Danielle",
     RealName: "Danielle June Marsh",
     Photo: "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/NJ_HowSweet_31-1.jpg"
    ),
    new Idol(
     Id: Guid.NewGuid(),
     GroupId: newJeansId,
     Name: "Haerin",
     RealName: "Kang Haerin",
     Photo: "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/NJ_HowSweet_26-1.jpg"
    ),
    new Idol(
     Id: Guid.NewGuid(),
     GroupId: newJeansId,
     Name: "Hyein",
     RealName: "Lee Hye-in",
     Photo: "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/NJ_HowSweet_03.jpg"
    )
   );
  });

  modelBuilder.Entity<Comment>(entity =>
  {
   entity.HasKey(e => e.Id);
   entity.HasOne<Group>()
    .WithMany()
    .HasForeignKey(e => e.GroupId);
   entity.HasOne<User>()
    .WithMany()
    .HasForeignKey(e => e.AuthorId);
   entity.Property(e => e.Content).IsRequired();
   entity.Property(e => e.CreatedAt).IsRequired();
   entity.Property(e => e.UpdatedAt);
  });
 }
}
