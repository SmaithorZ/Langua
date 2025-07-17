using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Langua.Migrations
{
    /// <inheritdoc />
    public partial class QuestionsforTextKladdkakansDagISverige : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Content", "CorrectOption", "TextId", "option1", "option2", "option3", "option4" },
                values: new object[,]
                {
                    { 54, "När firas Kladdkakans dag i Sverige?", 3, 14, "4 oktober", "25 december", "7 november", "1 maj" },
                    { 55, "Vad är kladdkaka?", 1, 14, "En söt, kladdig chokladkaka", "En mjuk kaka med sylt", "En frasig smördegskaka", "En sockerkaka med vanilj" },
                    { 56, "Vilken ingrediens används INTE i kladdkakan enligt receptet?", 3, 14, "Kakao", "Smör", "Mjölk", "Vetemjöl" },
                    { 57, "Vad händer om du gräddar kladdkakan kortare tid?", 2, 14, "Den blir torrare", "Den blir kladdigare", "Den smakar mindre", "Den blir hårdare" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 57);
        }
    }
}
