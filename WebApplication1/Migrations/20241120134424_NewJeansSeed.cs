using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class NewJeansSeed : Migration
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

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "Description", "Name", "Photo" },
                values: new object[,]
                {
                    { new Guid("c06c792f-379c-42c7-a833-ec3036ceae06"), "aespa is a 4-member girl group (Karina, Giselle, Winter, Ningning) from SM Entertainment that debuted on Nov 17th, 2020 with \"Black Mamba.\"\n\nLargely thought to be one of the groups that “started the 4th gen of K-Pop,” aespa is recognized for their theme of AIs and virtual reality. Throughout their album art, lyrics, music videos, and concept films, aespa has established unique lore of their own, drawing inspiration from sub-culture genres such as cyberpunk and frutiger aero, reminiscent of the Y2K trend.\n\naespa’s discography spans a variety of genres - including electronica, synthpop, hyperpop, trap, hiphop, R&B, and more.", "aespa", "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/GNEEkD4bgAASBoV.jpg" },
                    { new Guid("ee20ddcb-2cab-40bc-9733-5f61c6894cbd"), "NewJeans is a 5-member girl group (Minji, Hanni, Danielle, Haerin, Hyein) from ADOR that debuted on July 22nd, 2022 with “Attention.” \n\nOne of the most successful groups of the 4th generation of K-Pop, NewJeans is thought to have brought back the “easy listening” genre back to K-Pop, as well as popularizing the visual trend of the “girl next door” and “y2k concept” in the industry. NewJeans is known for their “natural” image; choosing minimalism over maximalism, or the typical level of “hyperproduction” in K-Pop. Super high notes, frantic beat changes, punchy rap verses, and super-synchronized dance routines are mostly absent from NewJeans’ hits.\n\nNewJeans is also loved for their “nostalgic” image and sound, blending mellow mid-tempo pop and R&B sounds with Jersey Club or Balitimore Club genre. Their overall concept has been called reminiscent of groups such as S.E.S, SPEED, and TLC.\n\nNewJeans is considered to be one of the major fashion icons in the K-Pop industry, with their signature “natural” look with minimal makeup and straight black hair which eventually branched out to other trends like balletcore and blokecore, coupled with collaborations with many fashion/beauty brands.", "New Jeans", "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/newjeans.jpeg" }
                });

            migrationBuilder.InsertData(
                table: "Idols",
                columns: new[] { "Id", "GroupId", "Name", "Photo", "RealName" },
                values: new object[,]
                {
                    { new Guid("0934a903-867a-4e65-93ff-7d18bfbb7e45"), new Guid("ee20ddcb-2cab-40bc-9733-5f61c6894cbd"), "Danielle", "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/NJ_HowSweet_31-1.jpg", "Danielle June Marsh" },
                    { new Guid("1c3ae36c-8512-41c4-b974-23d0c12e9428"), new Guid("c06c792f-379c-42c7-a833-ec3036ceae06"), "Ningning", "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/nn.jpeg", "Níng Yìzhuó" },
                    { new Guid("28492e16-3d3c-4921-84a6-5a5d8ddcb4eb"), new Guid("c06c792f-379c-42c7-a833-ec3036ceae06"), "Karina", "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/krn.jpeg", "Yoo Ji-min" },
                    { new Guid("3bca0e92-f43d-4ae6-adbd-022ba0ffa962"), new Guid("ee20ddcb-2cab-40bc-9733-5f61c6894cbd"), "Haerin", "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/NJ_HowSweet_26-1.jpg", "Kang Haerin" },
                    { new Guid("6ca8dec8-a7c6-4f75-91e6-578a2d3b565a"), new Guid("ee20ddcb-2cab-40bc-9733-5f61c6894cbd"), "Hanni", "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/NJ_HowSweet_19.jpg", "Hanni Pham" },
                    { new Guid("c43ee5ec-3e94-477e-aa1e-6efa64ff3635"), new Guid("c06c792f-379c-42c7-a833-ec3036ceae06"), "Winter", "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/wt.jpeg", "Kim Min-jeong" },
                    { new Guid("cc6b05be-d49a-4844-8248-b89de8440fe6"), new Guid("ee20ddcb-2cab-40bc-9733-5f61c6894cbd"), "Minji", "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/NJ_HowSweet_21.jpg", "Kim Min-ji" },
                    { new Guid("cdeee85d-3d71-4d46-abc5-7e06ffc69443"), new Guid("c06c792f-379c-42c7-a833-ec3036ceae06"), "Giselle", "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/gs.jpeg", "Aeri Uchinaga" },
                    { new Guid("fcc86049-a655-4b96-b354-76b75661d942"), new Guid("ee20ddcb-2cab-40bc-9733-5f61c6894cbd"), "Hyein", "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/NJ_HowSweet_03.jpg", "Lee Hye-in" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Idols",
                keyColumn: "Id",
                keyValue: new Guid("0934a903-867a-4e65-93ff-7d18bfbb7e45"));

            migrationBuilder.DeleteData(
                table: "Idols",
                keyColumn: "Id",
                keyValue: new Guid("1c3ae36c-8512-41c4-b974-23d0c12e9428"));

            migrationBuilder.DeleteData(
                table: "Idols",
                keyColumn: "Id",
                keyValue: new Guid("28492e16-3d3c-4921-84a6-5a5d8ddcb4eb"));

            migrationBuilder.DeleteData(
                table: "Idols",
                keyColumn: "Id",
                keyValue: new Guid("3bca0e92-f43d-4ae6-adbd-022ba0ffa962"));

            migrationBuilder.DeleteData(
                table: "Idols",
                keyColumn: "Id",
                keyValue: new Guid("6ca8dec8-a7c6-4f75-91e6-578a2d3b565a"));

            migrationBuilder.DeleteData(
                table: "Idols",
                keyColumn: "Id",
                keyValue: new Guid("c43ee5ec-3e94-477e-aa1e-6efa64ff3635"));

            migrationBuilder.DeleteData(
                table: "Idols",
                keyColumn: "Id",
                keyValue: new Guid("cc6b05be-d49a-4844-8248-b89de8440fe6"));

            migrationBuilder.DeleteData(
                table: "Idols",
                keyColumn: "Id",
                keyValue: new Guid("cdeee85d-3d71-4d46-abc5-7e06ffc69443"));

            migrationBuilder.DeleteData(
                table: "Idols",
                keyColumn: "Id",
                keyValue: new Guid("fcc86049-a655-4b96-b354-76b75661d942"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("c06c792f-379c-42c7-a833-ec3036ceae06"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("ee20ddcb-2cab-40bc-9733-5f61c6894cbd"));

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
