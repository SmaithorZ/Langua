using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Langua.Migrations
{
    /// <inheritdoc />
    public partial class QuestionsMitthusdjur : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Content", "CorrectOption", "TextId", "option1", "option2", "option3", "option4" },
                values: new object[,]
                {
                    { 1, "Hur gammal är Emma?", 2, 1, "Tio år", "Tretton år", "Fjorton år", "Tolv år" },
                    { 2, "Vad heter Emmas hund?", 2, 1, "Leo", "Max", "Lukas", "Rex" },
                    { 3, " Vad kan Max göra enligt texten?", 3, 1, "Prata och hoppa", "Rulla runt och skälla", "Sitta, ligga och ge tass", "Simma och dansa" },
                    { 4, "Vad gör familjen ibland på helgerna?", 2, 1, "Går på bio", "Åker till landet", "Besöker farföräldrarna", "Tittar på TV hela dagen" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
