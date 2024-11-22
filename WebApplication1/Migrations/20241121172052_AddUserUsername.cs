using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class AddUserUsername : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(256)",
                oldMaxLength: 256,
                oldNullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

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
        }
    }
}
