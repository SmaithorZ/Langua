using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Langua.Migrations
{
    /// <inheritdoc />
    public partial class AddQuestionsforLucasAnnaErikTexts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Content", "CorrectOption", "TextId", "option1", "option2", "option3", "option4" },
                values: new object[,]
                {
                    { 9, "Vad heter skolan där Lucas går?", 2, 3, "Solgården", "Solskolan", "Skolgården", "Solbacken" },
                    { 10, "Hur tar sig Lucas till skolan?", 3, 3, "Han går dit", "Han åker buss", "Han cyklar", "Han åker bil med sin mamma" },
                    { 11, "Var ligger Lucas klassrum?", 4, 3, "På första våningen", "Bredvid matsalen", "I källaren", "På andra våningen" },
                    { 12, "Vad är Lucas favoritplats i klassrummet?", 3, 3, "Vid whiteboarden", "Nära bokhyllan", "Vid fönstret", "Bredvid dörren" },
                    { 13, "Hur länge har Elin och Anna varit vänner?", 3, 4, "Ett år", "Två år", "Tre år", "Fem år" },
                    { 14, "Vad hänger på väggen i Elins rum?", 2, 4, "En spegel", "Ett porträtt som Anna har ritat", "En karta över världen", " En affisch med musikband" },
                    { 15, "Vad gör Elin och Anna ofta på helgerna?", 3, 4, "Går på bio", "Springer i parken", "Bakar muffins eller chokladkaka", "Tittar på serier" },
                    { 16, "Vilken typ av böcker tycker Anna om?", 3, 4, "Kärleksromaner", "Fakta-och historieböcker", "Äventyr och mysterier", "Diktsamlingar" },
                    { 17, "När inser Erik att han har glömt sitt paraply?", 4, 5, "När han dricker sitt kaffe", "När han går ut genom dörren", "När han ser andra med paraply", "När det börjar regna vid busshållplatsen " },
                    { 18, "Vad händer när Erik väntar på bussen?", 2, 5, "Han träffar en vän", "Det börjar regna kraftigt", "Bussen kommer i tid", "Han hittar ett paraply" },
                    { 19, "Hur känner sig Erik när han sitter på bussen?", 3, 5, "Han pratar med folk", "Han är glad och sjunger", "Han sitter tyst och tittar ut genom fönstret ", "Han sover" },
                    { 20, "Vad säger Eriks kollega när han kommer till jobbet?", 3, 5, "Du ser väldigt trött ut!", "Vill du ha en kopp kaffe?", "Du borde nog kolla vädret innan du går hemifrån!", "Varför tog du med paraply?" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 20);
        }
    }
}
