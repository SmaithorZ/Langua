using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Langua.Migrations
{
    /// <inheritdoc />
    public partial class QuestionsforMinFamiljOchVaraTraditioner : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Content", "CorrectOption", "TextId", "option1", "option2", "option3", "option4" },
                values: new object[,]
                {
                    { 21, "Vad jobbar huvudpersonens storasyster med?", 2, 6, "Lärare", "Sjuksköterska", "Elektriker", "Kafébiträde" },
                    { 22, "Vad brukar familjen göra på söndagar?", 3, 6, "Gå på bio tillsammans", "Städa hela huset", "Äta middag och spela sällskapsspel", "Titta på sport" },
                    { 23, "Vad tycker pappan om att göra?", 4, 6, "Spela gitarr", "Läsa böcker", "Träna på gym", "Fixa saker i huset" },
                    { 24, "Vad heter familjens katt och vad gillar den att göra?", 1, 6, "Maja – ligga i solen på balkongen", "Molly – jaga möss i trädgården", "Max – sova under soffan", "Mimmi – leka med barnen" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 24);
        }
    }
}
