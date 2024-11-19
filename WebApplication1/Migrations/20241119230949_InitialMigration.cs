using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Photo = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Idols",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    GroupId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    RealName = table.Column<string>(type: "text", nullable: false),
                    Photo = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Idols", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Idols_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Idols_GroupId",
                table: "Idols",
                column: "GroupId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Idols");

            migrationBuilder.DropTable(
                name: "Groups");
        }
    }
}
