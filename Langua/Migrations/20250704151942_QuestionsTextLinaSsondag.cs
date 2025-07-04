using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Langua.Migrations
{
    /// <inheritdoc />
    public partial class QuestionsTextLinaSsondag : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Content", "CorrectOption", "TextId", "option1", "option2", "option3", "option4" },
                values: new object[,]
                {
                    { 25, "Vad gör Lina först på söndagsmorgonen efter att hon har vaknat?", 2, 7, "Går ut på promenad", "Tar en lång dusch", "Ställer väckarklockan", "Städar lägenheten" },
                    { 26, "Vad brukar Lina göra vid elva på förmiddagen?", 3, 7, "Äta lunch", "Träffa sina föräldrar", "Gå på promenad i parken ", "Laga middag" },
                    { 27, "Vad gör Lina efter promenaden?", 2, 7, "Tittar på film", "Handlar mat och planerar middagar", "Tränar på gymmet", "Besöker en vän" },
                    { 28, "Vad gör Lina på kvällen?", 3, 7, "Går till biblioteket", "Städar hela lägenheten", "Lagar mat och ser en film eller läser en bok", "Går ut med vänner" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 28);
        }
    }
}
