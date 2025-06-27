using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Langua.Migrations
{
    /// <inheritdoc />
    public partial class addQuestionsForTextEnDagIParken : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Content", "CorrectOption", "TextId", "option1", "option2", "option3", "option4" },
                values: new object[,]
                {
                    { 5, "Vad gör den lilla pojken och hans pappa i parken?", 3, 2, "De spelar fotboll", "De matar fåglar", "De köper glass och sitter i gräset", "De läser böcker på en bänk" },
                    { 6, "Vilken smak på glassen väljer pojken?", 3, 2, "Vanilj", "Choklad", "Jordgubb", "Citron" },
                    { 7, "Vad händer när flickan gör mål i fotbollsmatchen?", 2, 2, "Hunden skäller", "Alla klappar händerna", "Pojken gråter", "Någon ramlar" },
                    { 8, "Vad gör den gamla mannen vid fontänen?", 1, 2, "Han matar duvor", "Han sover på en bänk", "Han läser en bok", "Han spelar gitarr" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}
