using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Langua.Migrations
{
    /// <inheritdoc />
    public partial class AddSlugForTexts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Slug",
                table: "Texts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Slug",
                value: "mitt-husdjur");

            migrationBuilder.UpdateData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Slug",
                value: "en-dag-i-parken");

            migrationBuilder.UpdateData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Slug",
                value: "lucas-berattar-om-sin-skola");

            migrationBuilder.UpdateData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 4,
                column: "Slug",
                value: "min-van-anna");

            migrationBuilder.UpdateData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 5,
                column: "Slug",
                value: "erik-glommer-sitt-paraply");

            migrationBuilder.UpdateData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 6,
                column: "Slug",
                value: "min-familj-och-vara-traditioner");

            migrationBuilder.UpdateData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 7,
                column: "Slug",
                value: "linas-sondag");

            migrationBuilder.UpdateData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 8,
                column: "Slug",
                value: "mitt-rum-i-lagenheten");

            migrationBuilder.UpdateData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 9,
                column: "Slug",
                value: "erik-skriver-ett-personligt-brev");

            migrationBuilder.UpdateData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 10,
                column: "Slug",
                value: "min-garderob");

            migrationBuilder.UpdateData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 11,
                column: "Slug",
                value: "goteborg");

            migrationBuilder.UpdateData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 12,
                column: "Slug",
                value: "sara-och-erik-bokar-en-resa");

            migrationBuilder.UpdateData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 13,
                column: "Slug",
                value: "familjen-eriksson-pa-botaniska-tradgarden");

            migrationBuilder.UpdateData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 14,
                column: "Slug",
                value: "kladdkakans-dag-i-sverige");

            migrationBuilder.UpdateData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 15,
                column: "Slug",
                value: "spelens-varld-mer-an-bara-underhallning");

            migrationBuilder.UpdateData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 16,
                column: "Slug",
                value: "svensk-natur-ar-som-en-sagovard");

            migrationBuilder.UpdateData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 17,
                column: "Slug",
                value: "moj-najlepszy-przyjaciel");

            migrationBuilder.UpdateData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 18,
                column: "Slug",
                value: "moj-dzien");

            migrationBuilder.UpdateData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 19,
                column: "Slug",
                value: "polskie-jedzenie");

            migrationBuilder.UpdateData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 20,
                column: "Slug",
                value: "po-szkole-gram-w-minecrafta");

            migrationBuilder.UpdateData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 21,
                column: "Slug",
                value: "urodziny-ani");

            migrationBuilder.UpdateData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 22,
                column: "Slug",
                value: "moje-codzienne-zycie");

            migrationBuilder.UpdateData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 23,
                column: "Slug",
                value: "podrozowanie-to-przygoda");

            migrationBuilder.UpdateData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 24,
                column: "Slug",
                value: "czas-wolny-mojej-rodziny");

            migrationBuilder.UpdateData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 25,
                column: "Slug",
                value: "studia-za-granica");

            migrationBuilder.UpdateData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 26,
                column: "Slug",
                value: "gdzie-mieszkam");

            migrationBuilder.UpdateData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 27,
                column: "Slug",
                value: "kolory");

            migrationBuilder.UpdateData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 28,
                column: "Slug",
                value: "zakupy");

            migrationBuilder.UpdateData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 29,
                column: "Slug",
                value: "cialo");

            migrationBuilder.UpdateData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 30,
                column: "Slug",
                value: "podroz-do-chin");

            migrationBuilder.UpdateData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 31,
                column: "Slug",
                value: "miasto-czy-wies");

            migrationBuilder.UpdateData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 32,
                column: "Slug",
                value: "kolacja-we-dwoje");

            migrationBuilder.UpdateData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 33,
                column: "Slug",
                value: "moy-den");

            migrationBuilder.UpdateData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 34,
                column: "Slug",
                value: "moy-drug");

            migrationBuilder.UpdateData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 35,
                column: "Slug",
                value: "puteshestvie-v-moskvu");

            migrationBuilder.UpdateData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 36,
                column: "Slug",
                value: "ishu-rabotu");

            migrationBuilder.UpdateData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 37,
                column: "Slug",
                value: "moy-pitomec");

            migrationBuilder.UpdateData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 38,
                column: "Slug",
                value: "moy-rasporyadok-dnya");

            migrationBuilder.UpdateData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 39,
                column: "Slug",
                value: "puteshestvie-v-sibir");

            migrationBuilder.UpdateData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 40,
                column: "Slug",
                value: "ya-povar");

            migrationBuilder.UpdateData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 41,
                column: "Slug",
                value: "russkaya-kuhnya");

            migrationBuilder.UpdateData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 42,
                column: "Slug",
                value: "moyo-utro");

            migrationBuilder.UpdateData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 43,
                column: "Slug",
                value: "o-sebe");

            migrationBuilder.UpdateData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 44,
                column: "Slug",
                value: "nezabyvaemye-vyhodnye-v-sankt-peterburge");

            migrationBuilder.UpdateData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 45,
                column: "Slug",
                value: "pervyy-rabochiy-den-v-novoy-kompanii");

            migrationBuilder.UpdateData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 46,
                column: "Slug",
                value: "pismo-drugu");

            migrationBuilder.UpdateData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 47,
                column: "Slug",
                value: "plany-na-budushchee");

            migrationBuilder.UpdateData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 48,
                column: "Slug",
                value: "zhizn-v-bolshom-gorode");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Slug",
                table: "Texts");
        }
    }
}
