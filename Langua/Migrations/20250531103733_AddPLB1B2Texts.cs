using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Langua.Migrations
{
    /// <inheritdoc />
    public partial class AddPLB1B2Texts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Texts",
                columns: new[] { "Id", "Language", "LanguageText", "Level", "TextTitle" },
                values: new object[,]
                {
                    { 25, "Polish", "Kasia od zawsze marzyła o studiowaniu za granicą. Już w liceum interesowała się kulturą innych krajów i chętnie uczyła się języków obcych. Po zdaniu matury postanowiła, że spróbuje swoich sił na zagranicznym uniwersytecie. Chciała nie tylko zdobyć dobrą edukację, ale także poznać nowych ludzi i rozwinąć się jako osoba.\r\n\r\nWybór kraju nie był prosty. Kasia brała pod uwagę Niemcy, Holandię i Szwecję. Wszystkie te kraje oferują programy studiów w języku angielskim, a dodatkowo mają dobrą reputację, jeśli chodzi o jakość nauczania. Ostatecznie wybrała Szwecję, ponieważ bardzo podobała jej się przyroda i styl życia mieszkańców.\r\n\r\nStudia za granicą to nie tylko nauka. Trzeba było załatwić wiele formalności – między innymi aplikować o wizę, znaleźć mieszkanie i zapisać się na kursy. Początki były trudne. Kasia nie znała nikogo w nowym miejscu, tęskniła za rodziną i musiała przyzwyczaić się do innego systemu nauczania.\r\n\r\nZ czasem jednak wszystko się zmieniło. Kasia poznała przyjaciół z różnych krajów, zaczęła mówić coraz lepiej po angielsku, a nawet uczyła się trochę szwedzkiego. Nauczyła się gotować, zarządzać swoim budżetem i być bardziej samodzielna. Dzisiaj uważa, że wyjazd na studia był jedną z najlepszych decyzji w jej życiu.\r\n\r\nStudia za granicą to duże wyzwanie, ale też ogromna szansa. Dzięki nim można nie tylko zdobyć wykształcenie, ale też lepiej poznać siebie i świat.", "B1", "Studia za granicą" },
                    { 26, "Polish", "Mieszkam w centrum Europy – w Polsce. Ale zgadnijcie, w jakim mieście dokładnie? Poniżej znajdziecie kilka wskazówek, które pomogą Wam odgadnąć tę tajemnicę.\r\n\r\nMoje miasto jest czwartym co do wielkości w Polsce, jeśli chodzi o liczbę mieszkańców. Można tu znaleźć miejsca, które mają takie same nazwy jak znane miejsca na świecie – na przykład Kilimandżaro czy Morskie Oko. Bardzo popularna jest również Fontanna Multimedialna, która znajduje się w pobliżu Hali Stulecia.\r\n\r\nJeszcze kilkadziesiąt lat temu to miasto nie było częścią Polski. Znajduje się tutaj wiele mostów, rzek i małych wysp. Przez centrum przepływa rzeka, a wokół starego miasta wciąż działa fosa, w której cały czas jest woda. Z mojego miasta bliżej jest do Berlina, stolicy Niemiec, niż do Warszawy – stolicy Polski.\r\n\r\nMiasto cieszy się ogromną popularnością wśród turystów – co roku odwiedzają je miliony osób. Wielu z nich zagląda do naszego znanego ZOO. Jedną z największych atrakcji jest Afrykarium, gdzie można oglądać egzotyczne zwierzęta w warunkach bardzo zbliżonych do naturalnych.\r\n\r\nMiłośnicy kultury także nie będą się nudzić – znajdą tu wiele teatrów, muzeów i kin. W 2016 roku miasto zostało Europejską Stolicą Kultury i Światową Stolicą Książki.\r\n\r\nCzy potrzebujecie jeszcze jednej wskazówki? Dobrze, oto ostatnia: łacińska nazwa tego miasta to Vratislavia, a po niemiecku nazywa się Breslau. Już wiecie? Tak, to Wrocław!", "B1", "Gdzie mieszkam" },
                    { 27, "Polish", "Cześć! Znowu się widzimy – mam na imię Ania i dzisiaj opowiem wam o kolorach, które lubię i których nie lubię. Od zawsze podobały mi się jasne i radosne kolory. Kiedy byłam mała, moimi ulubionymi kolorami były różowy, jasny niebieski i żółty. Mam zdjęcie z dzieciństwa, na którym mam na sobie różową sukienkę, jasnoniebieskie legginsy i żółte sandały. To jedno z moich najcenniejszych zdjęć!\r\n\r\nW wieku nastoletnim najbardziej lubiłam kolor czerwony – do dziś mam moją czerwoną sukienkę, w której chodziłam na wszystkie ważne uroczystości. Kiedy zaczęłam studia, polubiłam też pomarańczowy i jasną zieleń. Mam zielony szalik, rękawiczki i czapkę, które noszę zimą. Oprócz tego podobają mi się kolory takie jak biały, złoty i srebrny. Teraz moim ulubionym kolorem jest zielony, ale kto wie – może za kilka lat polubię fioletowy albo błękitny?\r\n\r\nNie przepadam za ciemnymi i smutnymi kolorami, na przykład czarnym, brązowym, szarym, granatowym czy ciemnozielonym. Raczej nie kupuję ubrań w takich kolorach. Mój pokój też jest urządzony w jasnych barwach – ciemnych kolorów jest w nim bardzo mało. Czasami jednak zakładam czarne lub szare rajstopy, bo pasują do wszystkiego. Mam też kilka dodatków – kolczyki, bransoletki i naszyjniki – w brązowych i srebrnych odcieniach. Ale jeśli chodzi o ubrania, to ciemne kolory są prawie nieobecne w mojej szafie.", "B1", "Kolory" },
                    { 28, "Polish", "Idę na zakupy. Moja dziewczyna Lila poprosiła mnie, żebym kupił wszystko na jej urodzinową kolację. Planuje duże przyjęcie – zaprosiła aż trzynaście osób. Lista zakupów jest długa, ale na szczęście wszystko mam zapisane.\r\n\r\nLila chce przygotować lasagne, więc muszę kupić sześć opakowań makaronu do lasagne i osiem puszek pomidorów. Potrzebne są też cztery cebule, czosnek i świeża bazylia. Do tego kupię też ser i trochę oliwy z oliwek.\r\n\r\nNa przystawkę Lila robi sałatkę grecką. Muszę kupić trzy ogórki, kilka pomidorów, dwa opakowania sera feta i oliwki. Do sosu mam kupić jeden jogurt naturalny i trochę przypraw.\r\n\r\nPrzyjęcie nie może się obyć bez przekąsek. Goście bardzo lubią słone rzeczy, więc biorę dziesięć paczek chipsów, sześć paczek krakersów i siedem paczek orzeszków. Dla dzieci kupiłem też trzy paczki żelków.\r\n\r\nNa deser będzie ciasto owocowe i sałatka owocowa. Kupiłem dwanaście bananów, piętnaście jabłek, osiem pomarańczy, sześć kiwi i pięć opakowań malin. Wszystko razem będzie bardzo kolorowe i smaczne.\r\n\r\nZostały mi już tylko napoje do kupienia. Wezmę dwadzieścia cztery puszki napojów gazowanych, dwadzieścia piw i trzy butelki wina. Mam jeszcze dziewięćdziesiąt złotych, więc kupię jedną butelkę szampana i tort waniliowy – to ulubiony smak Lili. Mam nadzieję, że impreza będzie udana!", "B1", "Zakupy" },
                    { 29, "Polish", "Cześć! Mam na imię Ania i mam dwadzieścia pięć lat. Dzisiaj opowiem wam o tym, jak wyglądam. Wiele osób nie jest zadowolonych ze swojego wyglądu ale ja lubię moje ciało.\r\n\r\nMam małą głowę. Moje włosy są długie i proste. Jestem brunetką. Moje oczy są duże i zielone. Mam gęste brwi i krótkie proste rzęsy. Mój nos jest długi i prosty. Mam pełne duże usta i proste białe zęby. Mam podwójny podbródek. Mam owalną twarz i jasną karnację. W lecie na mojej skórze widać piegi.\r\n\r\nMoja szyja jest długa i zgrabnie połączona z klatką piersiową. Moje plecy są proste a mój brzuch, ramiona i nogi są szczupłe i umięśnione. Jestem wysoka i smukła. Nie mam nadwagi lecz nie jestem również chuda. Jestem młoda więc moje barki, łokcie, dłonie i palce poruszają się sprawnie i bez problemów. Moje kolana nigdy mnie nie bolą. Moje stopy i kostki u nóg nigdy nie puchną. Czasami bolą mnie palce u stóp - szczególnie wtedy, kiedy noszę buty na wysokim obcasie. Bardzo o siebie dbam - zdrowo się odżywiam i uprawiam sport. Dlatego mam nadzieję że mój mózg, moje płuca, serce, wątroba, żołądek, nerki i jelita będą jak najdłużej sprawnie funkcjonować.", "B2", "Ciało" },
                    { 30, "Polish", "Mam na imię Marta, mam dwadzieścia sześć lat i pochodzę z Krakowa. Od zawsze interesowałam się kulturą azjatycką, a szczególnie fascynowały mnie Chiny – ich historia, kuchnia, język i tradycje. Dlatego rok temu postanowiłam zrealizować moje marzenie i pojechałam tam na trzy miesiące.\r\n\r\nPodróż rozpoczęłam w Pekinie. Miasto zrobiło na mnie ogromne wrażenie – było głośne, tętniące życiem i pełne kontrastów. Z jednej strony nowoczesne wieżowce, z drugiej – tradycyjne świątynie i wąskie uliczki hutongów. Odwiedziłam Zakazane Miasto, spacerowałam po Wielkim Murze Chińskim i próbowałam lokalnych potraw, takich jak kacza po pekińsku i pierożki dim sum.\r\n\r\nPo tygodniu ruszyłam do Xi’an, gdzie mogłam zobaczyć słynną armię terakotową. Następnie poleciałam do Chengdu – miasta znanego z pand. W centrum badań i ochrony pand mogłam zobaczyć te zwierzęta z bliska, co było niesamowitym przeżyciem.\r\n\r\nOstatni miesiąc spędziłam w Szanghaju, gdzie pracowałam jako wolontariuszka w szkole językowej. Uczyłam dzieci podstaw angielskiego, a one pomagały mi w nauce chińskiego. Dzięki temu mogłam naprawdę zanurzyć się w codzienne życie mieszkańców.\r\n\r\nChińska kultura bardzo różni się od polskiej, ale właśnie to było dla mnie najciekawsze. Musiałam nauczyć się nowych zasad – na przykład tego, że w Chinach nie zostawia się napiwków albo że hałas w restauracjach jest czymś zupełnie normalnym.\r\n\r\nPodróż do Chin była dla mnie ogromną przygodą i doświadczeniem, które zmieniło moje spojrzenie na świat. Nauczyłam się nie tylko nowych rzeczy o innym kraju, ale też wiele o sobie samej. Marzę o tym, żeby tam wrócić – tym razem na dłużej.", "B2", "Podróż do Chin" },
                    { 31, "Polish", "Od zawsze trwa dyskusja na temat tego, gdzie lepiej mieszkać – w mieście czy na wsi. Każde z tych miejsc ma swoje zalety i wady, a wybór często zależy od stylu życia, osobowości i priorytetów danej osoby.\r\n\r\nŻycie w mieście jest dynamiczne i pełne możliwości. Ludzie mieszkający w dużych miastach mają łatwiejszy dostęp do pracy, edukacji, kultury i rozrywki. Kino, teatr, siłownia, restauracja – wszystko jest na wyciągnięcie ręki. Komunikacja miejska umożliwia szybkie przemieszczanie się bez potrzeby posiadania własnego samochodu. Jednak życie w mieście wiąże się też z hałasem, stresem i zanieczyszczeniem powietrza. Często brakuje tam przestrzeni i kontaktu z naturą.\r\n\r\nZ drugiej strony, wieś oferuje ciszę, spokój i bliskość przyrody. Wiele osób decyduje się na przeprowadzkę na wieś, żeby zwolnić tempo życia i cieszyć się prostymi rzeczami – spacerem po lesie, śpiewem ptaków czy świeżym powietrzem. Ceny mieszkań na wsi są zwykle niższe niż w miastach, co pozwala na zakup większego domu z ogrodem. Jednak codzienne życie może być trudniejsze – szczególnie zimą, gdy do najbliższego sklepu lub lekarza trzeba jechać kilka kilometrów. Brakuje też wielu udogodnień, do których mieszkańcy miast są przyzwyczajeni.\r\n\r\nCoraz popularniejsze staje się rozwiązanie pośrednie – mieszkanie na obrzeżach miasta lub w małej miejscowości z dobrym dojazdem do dużego miasta. W ten sposób można korzystać z zalet obu światów – spokoju natury i wygody miejskiej infrastruktury.\r\n\r\nDla mnie najważniejsze jest, aby miejsce zamieszkania pasowało do mojego trybu życia i charakteru. Jedni potrzebują hałasu i ruchu, inni wolą ciszę i naturę. Niezależnie od wyboru, najważniejsze to czuć się dobrze tam, gdzie się mieszka.", "B2", "Miasto czy wieś?" },
                    { 32, "Polish", "W piątkowy wieczór Marta i Paweł postanowili wybrać się do restauracji. Oboje mieli za sobą intensywny tydzień pracy i uznali, że zasługują na chwilę relaksu i odrobinę luksusu. Zarezerwowali stolik w nowej włoskiej restauracji, która niedawno otworzyła się w centrum miasta. Słyszeli o niej wiele pozytywnych opinii i byli ciekawi, czy rzeczywiście jedzenie tam jest tak pyszne, jak wszyscy mówią.\r\n\r\nGdy weszli do lokalu, od razu poczuli przyjemny zapach ziół i świeżo pieczonego chleba. Wnętrze było eleganckie, ale jednocześnie przytulne. Kelner zaprowadził ich do stolika przy oknie. Złożyli zamówienie – Paweł wybrał tagliatelle z łososiem i szpinakiem, a Marta zdecydowała się na risotto z grzybami i parmezanem. Do tego zamówili butelkę czerwonego wina.\r\n\r\nPodczas kolacji rozmawiali o swoich planach na weekend, wspominali wspólne wakacje i śmiali się z drobnych codziennych sytuacji. Czas płynął szybko, a jedzenie rzeczywiście okazało się wyśmienite. Obsługa była uprzejma i profesjonalna, co dodatkowo wpłynęło na ich pozytywne wrażenia.\r\n\r\nNa deser zamówili tiramisu i panna cottę z malinowym sosem. Marta była zachwycona delikatnym smakiem i sposobem podania – deser wyglądał jak dzieło sztuki. Paweł zażartował, że chyba będą musieli częściej wychodzić do restauracji, skoro każde wyjście jest tak udane.\r\n\r\nWieczór zakończyli spacerem po oświetlonych uliczkach miasta. Oboje czuli się szczęśliwi i odprężeni. To była dla nich nie tylko pyszna kolacja, ale też ważny moment, kiedy mogli pobyć tylko we dwoje i na nowo poczuć bliskość w codziennym zabieganiu.", "B2", "Kolacja we dwoje" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 32);
        }
    }
}
