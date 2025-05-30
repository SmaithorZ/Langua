using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Langua.Migrations
{
    /// <inheritdoc />
    public partial class PLA1A2TextMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Texts",
                columns: new[] { "Id", "Language", "LanguageText", "Level", "TextTitle" },
                values: new object[,]
                {
                    { 17, "Polish", "Mam na imię Kuba i mam najlepszego przyjaciela. Nazywa się Tomek. Znamy się od dzieciństwa. Mieszkamy na tej samej ulicy i chodzimy razem do szkoły.\r\n\r\nTomek ma krótkie blond włosy i niebieskie oczy. Lubi grać w piłkę nożną i słuchać muzyki. Często gramy razem na komputerze.\r\n\r\nPo szkole spotykamy się w parku albo robimy zadania domowe razem. Tomek jest miły, zabawny i zawsze mi pomaga.\r\n\r\nCieszę się, że mam takiego przyjaciela!", "A1", "Mój najlepszy przyjaciel" },
                    { 18, "Polish", "Mam na imię Ola. Mam 20 lat i mieszkam w Krakowie. Każdego dnia wstaję o godzinie 7:00. Myję się, ubieram i jem śniadanie. Na śniadanie lubię jeść chleb z serem albo jajko na twardo. Zawsze piję herbatę, a czasem kawę.\r\n\r\nO 7:30 wychodzę z domu i idę na uczelnię. Mieszkam blisko, więc idę pieszo. Zajęcia zaczynają się o 8:00 i kończą się o 14:00. Studiuję psychologię i bardzo lubię moje studia.\r\n\r\nPo zajęciach wracam do domu i jem obiad. Najczęściej jem zupę i makaron albo ryż z warzywami. Potem odpoczywam, słucham muzyki lub rozmawiam z przyjaciółmi przez telefon.\r\n\r\nWieczorem często spaceruję po parku albo oglądam film. Lubię też czytać książki, zwłaszcza powieści i kryminały.\r\n\r\nKładę się spać o 22:30, bo rano muszę wcześnie wstać. Lubię mój dzień, bo jest spokojny i dobrze zorganizowany.", "A1", "Mój dzień" },
                    { 19, "Polish", "W Polsce jest dużo smacznego jedzenia. Polacy lubią jeść zupy, mięso i ziemniaki. Popularne zupy to rosół, żurek i pomidorowa. Rosół to zupa z kurczakiem, marchewką i makaronem. Jest bardzo popularna w niedzielę.\r\n\r\nNa obiad Polacy często jedzą kotlet schabowy z ziemniakami i kapustą. To jest panierowane mięso, smażone na patelni. Jest bardzo pyszne!\r\n\r\nNa deser Polacy lubią pączki, sernik i szarlotkę. Pączek to słodkie ciastko z marmoladą w środku i cukrem pudrem na górze.\r\n\r\nW Polsce popularne są też pierogi. Są z różnym nadzieniem: z mięsem, z kapustą i grzybami, albo na słodko – z truskawkami lub serem.\r\n\r\nPolskie jedzenie jest ciepłe, sycące i smaczne. Bardzo je lubię!", "A1", "Polskie jedzenie" },
                    { 20, "Polish", "Mam na imię Kuba i mam 10 lat. Mieszkam w Warszawie z mamą, tatą i młodszą siostrą. Chodzę do szkoły od poniedziałku do piątku. Lekcje zaczynają się o ósmej i kończą o czternastej.\r\n\r\nPo szkole jem obiad, odrabiam lekcje i potem mam czas wolny. Lubię grać w Minecrafta. To jest moja ulubiona gra! W Minecraftcie mogę budować domy, kopalnie i mosty. Czasem gram sam, a czasem z kolegami przez internet.\r\n\r\nNajbardziej lubię tryb kreatywny, bo mogę budować wszystko, co chcę. Mam też kota w grze i dużo diamentów. Granie w Minecrafta sprawia mi dużo radości!\r\n\r\nW weekendy mogę grać dłużej. To jest bardzo fajne!", "A1", "Po szkole gram w Minecrafta" },
                    { 21, "Polish", "Kiedy zbliża się listopad, Ania zaczyna się bardzo cieszyć. Dlaczego? Bo w listopadzie ma urodziny! To jej ulubiony miesiąc, bo wtedy może świętować razem z rodziną i przyjaciółmi.\r\n\r\nAnia zawsze planuje swoje urodziny wcześniej. Zaczyna od robienia listy gości. Zawsze zaprasza mamę, tatę, starszego brata i młodszą kuzynkę Zosię. Nie może też zabraknąć jej najlepszej przyjaciółki Kasi, z którą chodzi do tej samej klasy.\r\n\r\nCo roku Ania wybiera temat przewodni przyjęcia. W zeszłym roku były to księżniczki, a w tym roku Ania chce, żeby wszystko było w kolorze niebieskim, bo to jej ulubiony kolor. Dekoracje, balony i nawet serwetki mają być niebieskie!\r\n\r\nNajważniejszy na przyjęciu jest oczywiście tort. Mama zawsze piecze go sama. Ania pomaga przy dekoracji – dodaje kolorową posypkę i układa świeczki. W tym roku tort będzie waniliowy z truskawkowym kremem.\r\n\r\nPo zjedzeniu tortu wszyscy grają w gry – w chowanego, kalambury i czasem nawet w karaoke! Ania zawsze dostaje dużo prezentów, ale najbardziej cieszy się z tego, że może spędzić ten dzień z bliskimi osobami.", "A2", "Urodziny Ani" },
                    { 22, "Polish", "Mam na imię Michał. Mam 28 lat i mieszkam w Krakowie. To piękne miasto na południu Polski. Mieszkam tutaj od pięciu lat. Wcześniej mieszkałem w małej wiosce, ale przeprowadziłem się do miasta, żeby studiować i pracować.\r\n\r\nMam siostrę, która mieszka w Gdańsku. Rzadko się widzimy, ale często rozmawiamy przez telefon. Moi rodzice nadal mieszkają na wsi. Czasem jadę tam w weekend, żeby ich odwiedzić. Mama zawsze gotuje coś pysznego, a tata pokazuje mi, co nowego zrobił w ogrodzie.\r\n\r\nPracuję jako grafik komputerowy. Lubię swoją pracę, bo mogę być kreatywny. Pracuję z domu, więc nie muszę codziennie jeździć do biura. To bardzo wygodne. W wolnym czasie rysuję, gram w gry komputerowe i spaceruję po mieście.\r\n\r\nMam psa, który nazywa się Fado. To duży, biały pies. Chodzimy razem na spacery rano i wieczorem. Fado bardzo lubi dzieci i inne psy. Wszyscy na osiedlu go znają i lubią.\r\n\r\nLubię też podróżować. W zeszłym roku byłem w Czechach i na Słowacji. W tym roku chciałbym pojechać do Włoch. Marzę o tym, żeby zobaczyć Rzym i zjeść prawdziwą włoską pizzę!", "A2", "Moje codzienne życie" },
                    { 23, "Polish", "Lubię podróżować, bo każda podróż to nowa przygoda. Mam rower, samochód i czasem korzystam z pociągu albo autobusu. Lubię też długie spacery, zwłaszcza kiedy świeci słońce. Podczas podróży można zobaczyć coś nowego i poznać ciekawych ludzi.\r\n\r\nNajczęściej podróżuję po Polsce. Byłem już w wielu miastach, takich jak Kraków, Warszawa, Gdańsk i Wrocław. Każde miasto ma coś wyjątkowego. Ale nie tylko duże miasta są interesujące. Małe miasteczka i wsie też mają swój urok. Czasem są tam piękne kościoły, stare zamki albo malownicze parki.\r\n\r\nBardzo lubię jeździć nad morze. Słuchanie szumu fal i chodzenie boso po piasku to coś wspaniałego. Moje ulubione miejsca nad morzem to Ustka i Hel. Można tam łatwo dojechać pociągiem z wielu miejsc w Polsce.\r\n\r\nLubię też góry. W Tatrach byłem kilka razy. Wędrowałem po szlakach i podziwiałem widoki. Gdy ktoś chce zobaczyć piękne krajobrazy i poczuć świeże powietrze, powinien pojechać w góry. Ale uwaga – pogoda w górach zmienia się szybko, więc trzeba być przygotowanym.\r\n\r\nNie trzeba jednak jechać daleko, żeby coś przeżyć. Czasem wystarczy wyjść z domu i pójść do pobliskiego lasu lub parku. Przyroda jest wszędzie – wystarczy tylko rozejrzeć się uważnie.\r\n\r\nA Ty? Gdzie najbardziej lubisz podróżować? Może spotkamy się kiedyś w drodze?", "A2", "Podróżowanie to przygoda" },
                    { 24, "Polish", "Mam na imię Bartek. Mam 15 lat i chodzę do szkoły średniej. W wolnym czasie lubię grać na komputerze. Moją ulubioną grą jest Minecraft. Buduję tam domy, miasta, a czasem całe wyspy. Lubię też słuchać muzyki – najczęściej rocka i popu. Wieczorami często czytam książki o przygodach lub science fiction.\r\n\r\nMój młodszy brat Krzyś ma 10 lat. Bardzo lubi rysować. Ma dużo kolorowych kredek i markerów. Rysuje zwierzęta, samochody i postacie z bajek. Czasem razem gramy w gry planszowe albo budujemy coś z klocków LEGO. Krzyś nie lubi grać w gry komputerowe – mówi, że go męczą.\r\n\r\nNasza mama, pani Magda, uwielbia gotować. W weekendy próbuje nowe przepisy. Ostatnio piekła pizzę domową i robiła naleśniki z owocami. Cała rodzina je razem kolację. To dla nas ważny moment dnia.\r\n\r\nTata, pan Andrzej, często biega. Bierze udział w zawodach i trenuje kilka razy w tygodniu. W wolnym czasie lubi też czytać książki historyczne. Wie dużo o dawnych czasach i czasem opowiada nam ciekawe historie.\r\n\r\nCzasami w niedzielę wychodzimy razem na wycieczkę. Jeździmy do lasu, do zoo albo nad jezioro. Robimy zdjęcia i jemy kanapki na ławce. Lubię te chwile z rodziną. A Ty, jak spędzasz wolny czas?", "A2", "Czas wolny mojej rodziny" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 24);
        }
    }
}
