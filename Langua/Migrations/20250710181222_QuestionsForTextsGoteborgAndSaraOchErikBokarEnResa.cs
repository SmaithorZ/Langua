using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Langua.Migrations
{
    /// <inheritdoc />
    public partial class QuestionsForTextsGoteborgAndSaraOchErikBokarEnResa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Content", "CorrectOption", "TextId", "option1", "option2", "option3", "option4" },
                values: new object[,]
                {
                    { 41, "Hur länge stannade de i Göteborg?", 3, 11, "Två dagar", "Fyra dagar", "Tre dagar", "En vecka" },
                    { 42, "Vad gillade de mest med Göteborg enligt texten?", 2, 11, "Skyskraporna och nattlivet", "Parkerna och närheten till havet", "Shoppinggalleriorna", "Historiska museer" },
                    { 43, "Vad gjorde de i Slottsskogen?", 2, 11, "De tältade över natten", "De promenerade bland djur och grönområden", "De åt på ett kafé", "De spelade fotboll med lokalbefolkningen" },
                    { 44, "Vad gjorde de i Liseberg?", 1, 11, "De åkte karuseller, spelade på lyckohjul och åt sockervadd", "De gick på museum", "De såg en teaterföreställning", "De badade i en bassäng" },
                    { 45, "Vart vill Sara och Erik resa i sommar?", 3, 12, "Spanien", "Grekland", "Italien ", "Frankrike" },
                    { 46, "Hur länge vill de stanna i Rom?", 4, 12, "Två veckor", "Tio dagar", "En helg", "En vecka" },
                    { 47, "Vad ingår i deras bokningspaket?", 2, 12, "Endast flyg", "Flyg, hotell och frukost ", "Flyg och hyrbil", "Hotell och middag" },
                    { 48, "Varför vill de inte hyra bil?", 3, 12, "De har inte körkort", "De vill spara pengar", "De tänker promenera och åka tunnelbana", "Det finns inga bilar lediga" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 48);
        }
    }
}
