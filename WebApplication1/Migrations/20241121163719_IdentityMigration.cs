using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class IdentityMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Idols",
                keyColumn: "Id",
                keyValue: new Guid("2e353720-1967-4597-a945-9946f685ff8a"));

            migrationBuilder.DeleteData(
                table: "Idols",
                keyColumn: "Id",
                keyValue: new Guid("3f05982f-7bf5-4af1-bd2a-75eb1eaecb52"));

            migrationBuilder.DeleteData(
                table: "Idols",
                keyColumn: "Id",
                keyValue: new Guid("68040591-2641-4642-9c84-527f32ee06d1"));

            migrationBuilder.DeleteData(
                table: "Idols",
                keyColumn: "Id",
                keyValue: new Guid("a13b391a-d730-46c4-ad89-2b4901f4e0f8"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("92769f04-1066-473d-9417-7174c7a10665"));

            migrationBuilder.EnsureSchema(
                name: "identity");

            migrationBuilder.RenameTable(
                name: "Idols",
                newName: "Idols",
                newSchema: "identity");

            migrationBuilder.RenameTable(
                name: "Groups",
                newName: "Groups",
                newSchema: "identity");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                schema: "identity",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                schema: "identity",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Initials = table.Column<string>(type: "character varying(5)", maxLength: 5, nullable: true),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                schema: "identity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "identity",
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                schema: "identity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "identity",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                schema: "identity",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "identity",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                schema: "identity",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    RoleId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "identity",
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "identity",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                schema: "identity",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "identity",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "identity",
                table: "Groups",
                columns: new[] { "Id", "Description", "Name", "Photo" },
                values: new object[,]
                {
                    { new Guid("2d1ee165-f5c9-4d9b-8367-3f965c2e35ef"), "aespa is a 4-member girl group (Karina, Giselle, Winter, Ningning) from SM Entertainment that debuted on Nov 17th, 2020 with \"Black Mamba.\"\n\nLargely thought to be one of the groups that “started the 4th gen of K-Pop,” aespa is recognized for their theme of AIs and virtual reality. Throughout their album art, lyrics, music videos, and concept films, aespa has established unique lore of their own, drawing inspiration from sub-culture genres such as cyberpunk and frutiger aero, reminiscent of the Y2K trend.\n\naespa’s discography spans a variety of genres - including electronica, synthpop, hyperpop, trap, hiphop, R&B, and more.", "aespa", "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/GNEEkD4bgAASBoV.jpg" },
                    { new Guid("5faa9082-f4f2-4f65-846e-750f3a7f0c2b"), "NewJeans is a 5-member girl group (Minji, Hanni, Danielle, Haerin, Hyein) from ADOR that debuted on July 22nd, 2022 with “Attention.” \n\nOne of the most successful groups of the 4th generation of K-Pop, NewJeans is thought to have brought back the “easy listening” genre back to K-Pop, as well as popularizing the visual trend of the “girl next door” and “y2k concept” in the industry. NewJeans is known for their “natural” image; choosing minimalism over maximalism, or the typical level of “hyperproduction” in K-Pop. Super high notes, frantic beat changes, punchy rap verses, and super-synchronized dance routines are mostly absent from NewJeans’ hits.\n\nNewJeans is also loved for their “nostalgic” image and sound, blending mellow mid-tempo pop and R&B sounds with Jersey Club or Balitimore Club genre. Their overall concept has been called reminiscent of groups such as S.E.S, SPEED, and TLC.\n\nNewJeans is considered to be one of the major fashion icons in the K-Pop industry, with their signature “natural” look with minimal makeup and straight black hair which eventually branched out to other trends like balletcore and blokecore, coupled with collaborations with many fashion/beauty brands.", "New Jeans", "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/newjeans.jpeg" }
                });

            migrationBuilder.InsertData(
                schema: "identity",
                table: "Idols",
                columns: new[] { "Id", "GroupId", "Name", "Photo", "RealName" },
                values: new object[,]
                {
                    { new Guid("023d0d51-f921-4266-8fec-ec2c4dcbbe4d"), new Guid("2d1ee165-f5c9-4d9b-8367-3f965c2e35ef"), "Winter", "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/wt.jpeg", "Kim Min-jeong" },
                    { new Guid("4a57b92c-9344-4e4c-b873-28f94ee33607"), new Guid("5faa9082-f4f2-4f65-846e-750f3a7f0c2b"), "Danielle", "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/NJ_HowSweet_31-1.jpg", "Danielle June Marsh" },
                    { new Guid("4d2dab8d-3c4d-49b7-8c05-75640bdc0b5c"), new Guid("2d1ee165-f5c9-4d9b-8367-3f965c2e35ef"), "Giselle", "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/gs.jpeg", "Aeri Uchinaga" },
                    { new Guid("69d51bab-d59f-4686-96fe-38c24ed0afdd"), new Guid("5faa9082-f4f2-4f65-846e-750f3a7f0c2b"), "Hyein", "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/NJ_HowSweet_03.jpg", "Lee Hye-in" },
                    { new Guid("707e4633-801d-49ef-8139-5a4ea381cb3c"), new Guid("2d1ee165-f5c9-4d9b-8367-3f965c2e35ef"), "Karina", "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/krn.jpeg", "Yoo Ji-min" },
                    { new Guid("71d873d5-9a13-46a4-9122-f84c5f862c02"), new Guid("5faa9082-f4f2-4f65-846e-750f3a7f0c2b"), "Hanni", "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/NJ_HowSweet_19.jpg", "Hanni Pham" },
                    { new Guid("c056d157-0a3d-4849-895b-375d1c826778"), new Guid("5faa9082-f4f2-4f65-846e-750f3a7f0c2b"), "Minji", "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/NJ_HowSweet_21.jpg", "Kim Min-ji" },
                    { new Guid("c1f50695-3197-45c0-bae7-cabec918a9a0"), new Guid("2d1ee165-f5c9-4d9b-8367-3f965c2e35ef"), "Ningning", "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/nn.jpeg", "Níng Yìzhuó" },
                    { new Guid("c77c52a8-6bb5-4cf4-b5e3-6329157f2d53"), new Guid("5faa9082-f4f2-4f65-846e-750f3a7f0c2b"), "Haerin", "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/NJ_HowSweet_26-1.jpg", "Kang Haerin" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                schema: "identity",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                schema: "identity",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                schema: "identity",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                schema: "identity",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                schema: "identity",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                schema: "identity",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                schema: "identity",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims",
                schema: "identity");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims",
                schema: "identity");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins",
                schema: "identity");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles",
                schema: "identity");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens",
                schema: "identity");

            migrationBuilder.DropTable(
                name: "AspNetRoles",
                schema: "identity");

            migrationBuilder.DropTable(
                name: "AspNetUsers",
                schema: "identity");

            migrationBuilder.DeleteData(
                schema: "identity",
                table: "Idols",
                keyColumn: "Id",
                keyValue: new Guid("023d0d51-f921-4266-8fec-ec2c4dcbbe4d"));

            migrationBuilder.DeleteData(
                schema: "identity",
                table: "Idols",
                keyColumn: "Id",
                keyValue: new Guid("4a57b92c-9344-4e4c-b873-28f94ee33607"));

            migrationBuilder.DeleteData(
                schema: "identity",
                table: "Idols",
                keyColumn: "Id",
                keyValue: new Guid("4d2dab8d-3c4d-49b7-8c05-75640bdc0b5c"));

            migrationBuilder.DeleteData(
                schema: "identity",
                table: "Idols",
                keyColumn: "Id",
                keyValue: new Guid("69d51bab-d59f-4686-96fe-38c24ed0afdd"));

            migrationBuilder.DeleteData(
                schema: "identity",
                table: "Idols",
                keyColumn: "Id",
                keyValue: new Guid("707e4633-801d-49ef-8139-5a4ea381cb3c"));

            migrationBuilder.DeleteData(
                schema: "identity",
                table: "Idols",
                keyColumn: "Id",
                keyValue: new Guid("71d873d5-9a13-46a4-9122-f84c5f862c02"));

            migrationBuilder.DeleteData(
                schema: "identity",
                table: "Idols",
                keyColumn: "Id",
                keyValue: new Guid("c056d157-0a3d-4849-895b-375d1c826778"));

            migrationBuilder.DeleteData(
                schema: "identity",
                table: "Idols",
                keyColumn: "Id",
                keyValue: new Guid("c1f50695-3197-45c0-bae7-cabec918a9a0"));

            migrationBuilder.DeleteData(
                schema: "identity",
                table: "Idols",
                keyColumn: "Id",
                keyValue: new Guid("c77c52a8-6bb5-4cf4-b5e3-6329157f2d53"));

            migrationBuilder.DeleteData(
                schema: "identity",
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("2d1ee165-f5c9-4d9b-8367-3f965c2e35ef"));

            migrationBuilder.DeleteData(
                schema: "identity",
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("5faa9082-f4f2-4f65-846e-750f3a7f0c2b"));

            migrationBuilder.RenameTable(
                name: "Idols",
                schema: "identity",
                newName: "Idols");

            migrationBuilder.RenameTable(
                name: "Groups",
                schema: "identity",
                newName: "Groups");

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "Description", "Name", "Photo" },
                values: new object[] { new Guid("92769f04-1066-473d-9417-7174c7a10665"), "aespa is a 4-member girl group (Karina, Giselle, Winter, Ningning) from SM Entertainment that debuted on Nov 17th, 2020 with \"Black Mamba.\"\n\nLargely thought to be one of the groups that “started the 4th gen of K-Pop,” aespa is recognized for their theme of AIs and virtual reality. Throughout their album art, lyrics, music videos, and concept films, aespa has established unique lore of their own, drawing inspiration from sub-culture genres such as cyberpunk and frutiger aero, reminiscent of the Y2K trend.\n\naespa’s discography spans a variety of genres - including electronica, synthpop, hyperpop, trap, hiphop, R&B, and more.", "aespa", "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/GNEEkD4bgAASBoV.jpg" });

            migrationBuilder.InsertData(
                table: "Idols",
                columns: new[] { "Id", "GroupId", "Name", "Photo", "RealName" },
                values: new object[,]
                {
                    { new Guid("2e353720-1967-4597-a945-9946f685ff8a"), new Guid("92769f04-1066-473d-9417-7174c7a10665"), "Ningning", "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/nn.jpeg", "Níng Yìzhuó" },
                    { new Guid("3f05982f-7bf5-4af1-bd2a-75eb1eaecb52"), new Guid("92769f04-1066-473d-9417-7174c7a10665"), "Giselle", "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/gs.jpeg", "Aeri Uchinaga" },
                    { new Guid("68040591-2641-4642-9c84-527f32ee06d1"), new Guid("92769f04-1066-473d-9417-7174c7a10665"), "Winter", "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/wt.jpeg", "Kim Min-jeong" },
                    { new Guid("a13b391a-d730-46c4-ad89-2b4901f4e0f8"), new Guid("92769f04-1066-473d-9417-7174c7a10665"), "Karina", "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/krn.jpeg", "Yoo Ji-min" }
                });
        }
    }
}
