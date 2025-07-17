using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Langua.Migrations
{
    /// <inheritdoc />
    public partial class QuestionsTextSpelensVarld : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Content", "CorrectOption", "TextId", "option1", "option2", "option3", "option4" },
                values: new object[,]
                {
                    { 58, "Vilka färdigheter kan man utveckla genom att spela multiplayer-spel?", 2, 15, "Bara reflexer och snabbhet", "Kommunikation, lagarbete och strategiskt tänkande", "Matlagning och hantverk", " Läsa och skriva poesi" },
                    { 59, "Vad är e-sport enligt texten?", 3, 15, "Ett enkelt spel för barn", "Ett sätt att spela ensam", "En global företeelse där professionella tävlar och många tittar online", " Ett träningsprogram för gym" },
                    { 60, "Vilken kritik nämns i texten om spel?", 1, 15, "Spel kan leda till beroende och påverka livet negativt ", "De förstör grafikkort", "Spel är för dyra", "De är för svåra att förstå" },
                    { 61, "Vad säger texten om framtiden för spelindustrin?", 3, 15, "Den kommer troligen att minska", "Den är osäker på grund av bristande intresse", "Den ser spännande ut med ny teknik som VR och AI ", "Den kommer att försvinna helt" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 61);
        }
    }
}
