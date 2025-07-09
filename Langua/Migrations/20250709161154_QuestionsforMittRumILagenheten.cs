using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Langua.Migrations
{
    /// <inheritdoc />
    public partial class QuestionsforMittRumILagenheten : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Content", "CorrectOption", "TextId", "option1", "option2", "option3", "option4" },
                values: new object[,]
                {
                    { 29, "Vad finns i personens rum enligt texten?", 2, 8, "En dubbelsäng och en TV", "En enkelsäng, skrivbord, stol och bokhylla", "Ett kök och ett matbord", " En våningssäng och ett piano" },
                    { 30, "Vad står under fönstret i rummet?", 3, 8, "Ett skrivbord", "En bokhylla", "En liten soffa", " En garderob" },
                    { 31, "Vilken växt är personens favorit?", 4, 8, "En ros", "En orkidé", "En solros", "En liten kaktus" },
                    { 32, "Vad tycker personen bäst om med sitt rum?", 2, 8, "Att det är stort och fullt av teknik", "De gröna väggarna och att det är tyst", "Att det finns mycket mat", "Att det ligger nära universitetet" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 32);
        }
    }
}
