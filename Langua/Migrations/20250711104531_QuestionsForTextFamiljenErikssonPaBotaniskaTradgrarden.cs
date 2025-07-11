using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Langua.Migrations
{
    /// <inheritdoc />
    public partial class QuestionsForTextFamiljenErikssonPaBotaniskaTradgrarden : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Content", "CorrectOption", "TextId", "option1", "option2", "option3", "option4" },
                values: new object[,]
                {
                    { 49, "Vad tycker Sofia mest om i den botaniska trädgården?", 3, 13, "Körsbärsträd", "Kaktusar", "Orkidéer", "Gamla ekar" },
                    { 50, "Varför fotograferar Johan träd?", 2, 13, "För att skicka bilder till en tävling", "För sitt fotoprojekt i skolan", "För att visa sin farmor", "För att sälja dem online" },
                    { 51, "Vad gillar mamma Maria mest med den japanska delen av trädgården?", 4, 13, "Växthusen", "De gamla trädens rötter", "Fåglarna i träden", "Dammar, stenbroar och körsbärsträd" },
                    { 52, "Vad gör familjen alltid efter promenaden i trädgården?", 2, 13, "Går hem direkt", "Sätter sig vid caféet och fikar", "Besöker ett museum", "Tar en guidad tur" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 52);
        }
    }
}
