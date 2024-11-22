using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class ChangeEmailToUsername : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "identity",
                table: "Idols",
                keyColumn: "Id",
                keyValue: new Guid("25485a8f-efdf-4508-a660-e60edee5806a"));

            migrationBuilder.DeleteData(
                schema: "identity",
                table: "Idols",
                keyColumn: "Id",
                keyValue: new Guid("68527dfa-cdef-4d03-934f-1a6b759cfe8e"));

            migrationBuilder.DeleteData(
                schema: "identity",
                table: "Idols",
                keyColumn: "Id",
                keyValue: new Guid("7d8b2b22-104c-4aae-92d4-f766e3cd0dcf"));

            migrationBuilder.DeleteData(
                schema: "identity",
                table: "Idols",
                keyColumn: "Id",
                keyValue: new Guid("88ffa273-3a8f-412d-91be-72d612cb6d19"));

            migrationBuilder.DeleteData(
                schema: "identity",
                table: "Idols",
                keyColumn: "Id",
                keyValue: new Guid("8af8a85b-6be9-4ed9-8b45-cf846dc0d301"));

            migrationBuilder.DeleteData(
                schema: "identity",
                table: "Idols",
                keyColumn: "Id",
                keyValue: new Guid("8be39498-4854-44dc-8dea-dbcefb3d42fb"));

            migrationBuilder.DeleteData(
                schema: "identity",
                table: "Idols",
                keyColumn: "Id",
                keyValue: new Guid("91f2ce0e-1257-4b3f-ab69-bcf6031a7cce"));

            migrationBuilder.DeleteData(
                schema: "identity",
                table: "Idols",
                keyColumn: "Id",
                keyValue: new Guid("cf1207d4-ec55-4add-9185-3946eee83d30"));

            migrationBuilder.DeleteData(
                schema: "identity",
                table: "Idols",
                keyColumn: "Id",
                keyValue: new Guid("eee5bda3-d4f1-4b7e-8933-f0e3d08c61f7"));

            migrationBuilder.DeleteData(
                schema: "identity",
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("47c988ee-821d-45c6-88f1-98d98580558a"));

            migrationBuilder.DeleteData(
                schema: "identity",
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("7db1befe-4f33-475b-b5c3-286052e4dfb9"));

            migrationBuilder.DropColumn(
                name: "UserName",
                schema: "identity",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "username",
                schema: "identity",
                table: "AspNetUsers",
                newName: "UserName");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                schema: "identity",
                table: "AspNetUsers",
                type: "character varying(256)",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.InsertData(
                schema: "identity",
                table: "Groups",
                columns: new[] { "Id", "Description", "Name", "Photo" },
                values: new object[,]
                {
                    { new Guid("190678ba-3fdf-4414-8966-ad8adb3a96c8"), "aespa is a 4-member girl group (Karina, Giselle, Winter, Ningning) from SM Entertainment that debuted on Nov 17th, 2020 with \"Black Mamba.\"\n\nLargely thought to be one of the groups that “started the 4th gen of K-Pop,” aespa is recognized for their theme of AIs and virtual reality. Throughout their album art, lyrics, music videos, and concept films, aespa has established unique lore of their own, drawing inspiration from sub-culture genres such as cyberpunk and frutiger aero, reminiscent of the Y2K trend.\n\naespa’s discography spans a variety of genres - including electronica, synthpop, hyperpop, trap, hiphop, R&B, and more.", "aespa", "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/GNEEkD4bgAASBoV.jpg" },
                    { new Guid("563943bd-dff1-4d99-8359-7033d1d1aad0"), "NewJeans is a 5-member girl group (Minji, Hanni, Danielle, Haerin, Hyein) from ADOR that debuted on July 22nd, 2022 with “Attention.” \n\nOne of the most successful groups of the 4th generation of K-Pop, NewJeans is thought to have brought back the “easy listening” genre back to K-Pop, as well as popularizing the visual trend of the “girl next door” and “y2k concept” in the industry. NewJeans is known for their “natural” image; choosing minimalism over maximalism, or the typical level of “hyperproduction” in K-Pop. Super high notes, frantic beat changes, punchy rap verses, and super-synchronized dance routines are mostly absent from NewJeans’ hits.\n\nNewJeans is also loved for their “nostalgic” image and sound, blending mellow mid-tempo pop and R&B sounds with Jersey Club or Balitimore Club genre. Their overall concept has been called reminiscent of groups such as S.E.S, SPEED, and TLC.\n\nNewJeans is considered to be one of the major fashion icons in the K-Pop industry, with their signature “natural” look with minimal makeup and straight black hair which eventually branched out to other trends like balletcore and blokecore, coupled with collaborations with many fashion/beauty brands.", "New Jeans", "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/newjeans.jpeg" }
                });

            migrationBuilder.InsertData(
                schema: "identity",
                table: "Idols",
                columns: new[] { "Id", "GroupId", "Name", "Photo", "RealName" },
                values: new object[,]
                {
                    { new Guid("00cab4fc-9d36-42f2-bff9-c8f6a037ad96"), new Guid("563943bd-dff1-4d99-8359-7033d1d1aad0"), "Hyein", "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/NJ_HowSweet_03.jpg", "Lee Hye-in" },
                    { new Guid("17c7f97b-160b-45e1-a48a-ca37e85dff40"), new Guid("190678ba-3fdf-4414-8966-ad8adb3a96c8"), "Ningning", "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/nn.jpeg", "Níng Yìzhuó" },
                    { new Guid("2623b6e1-5e32-4e6c-9cb7-12eaa9a36344"), new Guid("563943bd-dff1-4d99-8359-7033d1d1aad0"), "Hanni", "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/NJ_HowSweet_19.jpg", "Hanni Pham" },
                    { new Guid("6390c23c-efbf-4539-ae30-7c5459c3ea6b"), new Guid("563943bd-dff1-4d99-8359-7033d1d1aad0"), "Danielle", "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/NJ_HowSweet_31-1.jpg", "Danielle June Marsh" },
                    { new Guid("693a1628-9762-4138-9ab1-7702a3349a7c"), new Guid("190678ba-3fdf-4414-8966-ad8adb3a96c8"), "Giselle", "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/gs.jpeg", "Aeri Uchinaga" },
                    { new Guid("69ae078d-c1f9-43a0-b165-f304b4df5e90"), new Guid("563943bd-dff1-4d99-8359-7033d1d1aad0"), "Haerin", "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/NJ_HowSweet_26-1.jpg", "Kang Haerin" },
                    { new Guid("8636460f-083c-489c-a587-ab3469be33bc"), new Guid("190678ba-3fdf-4414-8966-ad8adb3a96c8"), "Winter", "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/wt.jpeg", "Kim Min-jeong" },
                    { new Guid("90e31e4e-d907-463c-88cb-4cc5f6a9cb2f"), new Guid("563943bd-dff1-4d99-8359-7033d1d1aad0"), "Minji", "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/NJ_HowSweet_21.jpg", "Kim Min-ji" },
                    { new Guid("cdc09fea-109b-443e-9632-702afd8a5676"), new Guid("190678ba-3fdf-4414-8966-ad8adb3a96c8"), "Karina", "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/krn.jpeg", "Yoo Ji-min" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "identity",
                table: "Idols",
                keyColumn: "Id",
                keyValue: new Guid("00cab4fc-9d36-42f2-bff9-c8f6a037ad96"));

            migrationBuilder.DeleteData(
                schema: "identity",
                table: "Idols",
                keyColumn: "Id",
                keyValue: new Guid("17c7f97b-160b-45e1-a48a-ca37e85dff40"));

            migrationBuilder.DeleteData(
                schema: "identity",
                table: "Idols",
                keyColumn: "Id",
                keyValue: new Guid("2623b6e1-5e32-4e6c-9cb7-12eaa9a36344"));

            migrationBuilder.DeleteData(
                schema: "identity",
                table: "Idols",
                keyColumn: "Id",
                keyValue: new Guid("6390c23c-efbf-4539-ae30-7c5459c3ea6b"));

            migrationBuilder.DeleteData(
                schema: "identity",
                table: "Idols",
                keyColumn: "Id",
                keyValue: new Guid("693a1628-9762-4138-9ab1-7702a3349a7c"));

            migrationBuilder.DeleteData(
                schema: "identity",
                table: "Idols",
                keyColumn: "Id",
                keyValue: new Guid("69ae078d-c1f9-43a0-b165-f304b4df5e90"));

            migrationBuilder.DeleteData(
                schema: "identity",
                table: "Idols",
                keyColumn: "Id",
                keyValue: new Guid("8636460f-083c-489c-a587-ab3469be33bc"));

            migrationBuilder.DeleteData(
                schema: "identity",
                table: "Idols",
                keyColumn: "Id",
                keyValue: new Guid("90e31e4e-d907-463c-88cb-4cc5f6a9cb2f"));

            migrationBuilder.DeleteData(
                schema: "identity",
                table: "Idols",
                keyColumn: "Id",
                keyValue: new Guid("cdc09fea-109b-443e-9632-702afd8a5676"));

            migrationBuilder.DeleteData(
                schema: "identity",
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("190678ba-3fdf-4414-8966-ad8adb3a96c8"));

            migrationBuilder.DeleteData(
                schema: "identity",
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("563943bd-dff1-4d99-8359-7033d1d1aad0"));

            migrationBuilder.RenameColumn(
                name: "UserName",
                schema: "identity",
                table: "AspNetUsers",
                newName: "username");

            migrationBuilder.AlterColumn<string>(
                name: "username",
                schema: "identity",
                table: "AspNetUsers",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(256)",
                oldMaxLength: 256);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                schema: "identity",
                table: "AspNetUsers",
                type: "character varying(256)",
                maxLength: 256,
                nullable: true);

            migrationBuilder.InsertData(
                schema: "identity",
                table: "Groups",
                columns: new[] { "Id", "Description", "Name", "Photo" },
                values: new object[,]
                {
                    { new Guid("47c988ee-821d-45c6-88f1-98d98580558a"), "NewJeans is a 5-member girl group (Minji, Hanni, Danielle, Haerin, Hyein) from ADOR that debuted on July 22nd, 2022 with “Attention.” \n\nOne of the most successful groups of the 4th generation of K-Pop, NewJeans is thought to have brought back the “easy listening” genre back to K-Pop, as well as popularizing the visual trend of the “girl next door” and “y2k concept” in the industry. NewJeans is known for their “natural” image; choosing minimalism over maximalism, or the typical level of “hyperproduction” in K-Pop. Super high notes, frantic beat changes, punchy rap verses, and super-synchronized dance routines are mostly absent from NewJeans’ hits.\n\nNewJeans is also loved for their “nostalgic” image and sound, blending mellow mid-tempo pop and R&B sounds with Jersey Club or Balitimore Club genre. Their overall concept has been called reminiscent of groups such as S.E.S, SPEED, and TLC.\n\nNewJeans is considered to be one of the major fashion icons in the K-Pop industry, with their signature “natural” look with minimal makeup and straight black hair which eventually branched out to other trends like balletcore and blokecore, coupled with collaborations with many fashion/beauty brands.", "New Jeans", "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/newjeans.jpeg" },
                    { new Guid("7db1befe-4f33-475b-b5c3-286052e4dfb9"), "aespa is a 4-member girl group (Karina, Giselle, Winter, Ningning) from SM Entertainment that debuted on Nov 17th, 2020 with \"Black Mamba.\"\n\nLargely thought to be one of the groups that “started the 4th gen of K-Pop,” aespa is recognized for their theme of AIs and virtual reality. Throughout their album art, lyrics, music videos, and concept films, aespa has established unique lore of their own, drawing inspiration from sub-culture genres such as cyberpunk and frutiger aero, reminiscent of the Y2K trend.\n\naespa’s discography spans a variety of genres - including electronica, synthpop, hyperpop, trap, hiphop, R&B, and more.", "aespa", "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/GNEEkD4bgAASBoV.jpg" }
                });

            migrationBuilder.InsertData(
                schema: "identity",
                table: "Idols",
                columns: new[] { "Id", "GroupId", "Name", "Photo", "RealName" },
                values: new object[,]
                {
                    { new Guid("25485a8f-efdf-4508-a660-e60edee5806a"), new Guid("47c988ee-821d-45c6-88f1-98d98580558a"), "Haerin", "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/NJ_HowSweet_26-1.jpg", "Kang Haerin" },
                    { new Guid("68527dfa-cdef-4d03-934f-1a6b759cfe8e"), new Guid("47c988ee-821d-45c6-88f1-98d98580558a"), "Hyein", "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/NJ_HowSweet_03.jpg", "Lee Hye-in" },
                    { new Guid("7d8b2b22-104c-4aae-92d4-f766e3cd0dcf"), new Guid("7db1befe-4f33-475b-b5c3-286052e4dfb9"), "Ningning", "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/nn.jpeg", "Níng Yìzhuó" },
                    { new Guid("88ffa273-3a8f-412d-91be-72d612cb6d19"), new Guid("7db1befe-4f33-475b-b5c3-286052e4dfb9"), "Winter", "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/wt.jpeg", "Kim Min-jeong" },
                    { new Guid("8af8a85b-6be9-4ed9-8b45-cf846dc0d301"), new Guid("47c988ee-821d-45c6-88f1-98d98580558a"), "Hanni", "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/NJ_HowSweet_19.jpg", "Hanni Pham" },
                    { new Guid("8be39498-4854-44dc-8dea-dbcefb3d42fb"), new Guid("7db1befe-4f33-475b-b5c3-286052e4dfb9"), "Giselle", "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/gs.jpeg", "Aeri Uchinaga" },
                    { new Guid("91f2ce0e-1257-4b3f-ab69-bcf6031a7cce"), new Guid("47c988ee-821d-45c6-88f1-98d98580558a"), "Danielle", "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/NJ_HowSweet_31-1.jpg", "Danielle June Marsh" },
                    { new Guid("cf1207d4-ec55-4add-9185-3946eee83d30"), new Guid("7db1befe-4f33-475b-b5c3-286052e4dfb9"), "Karina", "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/krn.jpeg", "Yoo Ji-min" },
                    { new Guid("eee5bda3-d4f1-4b7e-8933-f0e3d08c61f7"), new Guid("47c988ee-821d-45c6-88f1-98d98580558a"), "Minji", "https://www.ipduck-kpop.wiki/content/images/size/w1600/2024/05/NJ_HowSweet_21.jpg", "Kim Min-ji" }
                });
        }
    }
}
