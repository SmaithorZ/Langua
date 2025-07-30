using Langua.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Langua.Data
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

       public DbSet<Text> Texts { get; set; }

        public DbSet<Question> Questions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Text>().HasData(
                
                new Text 
                {
                    Id = 1,
                    TextTitle = "Mitt husdjur",
                    LanguageText = "Jag heter Emma och jag är tretton år. Jag bor i ett litet hus med min mamma, min pappa och vårt husdjur. Vi har en hund som heter Max. Han är tre år gammal och väldigt snäll.\r\n\r\nVarje morgon går jag ut med Max innan jag går till skolan. Han gillar att springa och leka i parken. När jag kommer hem från skolan, väntar han alltid vid dörren. Då brukar vi leka lite till eller gå en promenad tillsammans.\r\n\r\nMin mamma tycker också mycket om Max. Hon köper ofta leksaker och godis till honom. Min pappa gillar att träna honom. Max kan sitta, ligga och ge tass. Han är väldigt smart!\r\n\r\nPå helgerna åker vi ibland till landet. Max älskar att vara där, för han kan springa fritt. Han jagar fjärilar och nosar på allt.\r\n\r\nJag älskar min hund och kan inte tänka mig ett liv utan honom.",
                    Language = "Swedish",
                    Level = "A1",
                    Slug = "mitt-husdjur"
                },

                new Text
                {
                    Id = 2,
                    TextTitle = "En dag i parken",
                    LanguageText = "Det är lördag och vädret är fint. Solen skiner och det är varmt i luften. Många människor är ute. Några sitter på bänkar och läser böcker. Andra går promenader eller leker med sina barn.\r\n\r\nEn liten pojke cyklar runt med sin pappa. De stannar vid en glasskiosk och köper varsin glass. Pappan tar choklad och pojken väljer jordgubb. De sätter sig i gräset och äter i solen. Fåglarna kvittrar i träden och det luktar blommor överallt.\r\n\r\nLite längre bort spelar några ungdomar fotboll. De skrattar och springer mycket. En hund springer efter bollen och alla tycker det är roligt. En flicka gör mål och alla klappar händerna.\r\n\r\nEn gammal man matar duvor vid fontänen. Han har med sig en liten påse med bröd. Duvorna flyger runt honom och pickar på marken.\r\n\r\nPå eftermiddagen börjar det blåsa lite, men solen är fortfarande framme. Några människor går hem, men många stannar kvar. Det är en härlig dag i parken och alla verkar glada.",
                    Language = "Swedish",
                    Level = "A1",
                    Slug = "en-dag-i-parken"
                },

                new Text
                {
                    Id = 3,
                    TextTitle = "Lucas berättar om sin skola",
                    LanguageText = "Jag heter Lucas och jag går i en skola som heter Solskolan. Den ligger tio minuter från mitt hus. Jag brukar cykla dit varje morgon. Skolan är ganska stor och har många klassrum, en matsal och en gympasal.\r\n\r\nMitt klassrum ligger på andra våningen. Det finns stora fönster så rummet är ljust. I klassrummet har vi bänkar, stolar, en whiteboard och en stor klocka på väggen. Längst bak i rummet finns en bokhylla med böcker som vi får läsa på rasterna.\r\n\r\nMin favoritplats är vid fönstret. Där sitter jag varje dag. Jag tycker om att titta ut när jag tänker. På väggarna i klassrummet hänger teckningar och affischer med svenska ord och bilder.\r\n\r\nVi har också ett grupprum bredvid klassrummet. Där jobbar vi ibland i små grupper. Det är tystare där, och det finns ett litet bord och några stolar.\r\n\r\nJag gillar min skola. Den är fin och jag trivs bra där.",
                    Language = "Swedish",
                    Level = "A1",
                    Slug = "lucas-berattar-om-sin-skola"
                },

                new Text
                {
                    Id = 4,
                    TextTitle = "Min vän Anna",
                    LanguageText = "Jag heter Elin och min bästa vän heter Anna. Vi träffades i skolan för tre år sedan och har varit vänner sedan dess. Anna är 17 år och bor nära mig, så vi ses nästan varje dag.\r\n\r\nAnna har långt blont hår och gröna ögon. Hon är ganska kort och skrattar mycket. Hon tycker om att rita och lyssna på musik. Ibland ritar hon porträtt av sina vänner, och hon har ritat ett jättefint porträtt av mig. Det hänger på väggen i mitt rum.\r\n\r\nVi tycker båda om att baka, så ofta gör vi muffins eller chokladkaka tillsammans på helgerna. Anna gillar också att läsa böcker, särskilt böcker om äventyr och mysterier. Jag brukar låna böcker av henne när jag inte har något att läsa.\r\n\r\nHon är snäll, rolig och alltid hjälpsam. När jag är ledsen, får hon mig att skratta. Jag är glad att jag har en vän som Anna. Jag hoppas att vi alltid kommer att vara vänner.",
                    Language = "Swedish",
                    Level = "A1",
                    Slug = "min-van-anna"
                },

                new Text
                {
                    Id = 5,
                    TextTitle = "Erik glömmer sitt paraply",
                    LanguageText = "Det är måndag morgon och Erik har bråttom till jobbet. Himlen är grå och det blåser lite, men han tänker inte så mycket på vädret. Han dricker snabbt sitt kaffe, tar på sig jackan och springer till bussen.\r\n\r\nNär han kommer fram till busshållplatsen börjar det regna. Först bara några droppar, men snart blir det ett riktigt ösregn. Erik letar i sin väska efter sitt paraply, men då kommer han på att han glömde det i hallen hemma.\r\n\r\nBussen är sen, och Erik blir blöt. När bussen äntligen kommer är hans byxor och skor redan genomvåta. På bussen sitter han tyst och tittar ut genom fönstret. Alla andra verkar ha tagit med sig paraply.\r\n\r\nNär han kommer till jobbet, skrattar hans kollega och säger:\r\n– Du borde nog kolla vädret innan du går hemifrån!\r\n\r\nErik ler och går direkt till toaletten för att torka sig lite. Nästa gång, tänker han, ska han inte glömma paraplyet.",
                    Language = "Swedish",
                    Level = "A2",
                    Slug = "erik-glommer-sitt-paraply"
                },

                new Text
                {
                    Id = 6,
                    TextTitle = "Min familj och våra traditioner",
                    LanguageText = "Vi är fyra personer i min familj: min mamma, min pappa, min storasyster och jag. Jag är 20 år gammal och bor fortfarande hemma medan jag studerar på universitetet. Min syster är 23 och jobbar som sjuksköterska på ett sjukhus i närheten.\r\n\r\nMin pappa är 52 år och arbetar som elektriker. Han tycker om att fixa saker i huset och är väldigt händig. Min mamma är 49 år och jobbar deltid på ett café. Hon älskar att baka och lagar alltid god mat till familjen.\r\n\r\nVarje söndag har vi en tradition. Vi äter middag tillsammans och spelar sällskapsspel efteråt. Ibland bjuder vi också in våra morföräldrar. Det är alltid trevligt, och vi skrattar mycket.\r\n\r\nVi har också en katt som heter Maja. Hon är vit med svarta fläckar och gillar att ligga i solen på balkongen. Hon är en viktig del av familjen.",
                    Language = "Swedish",
                    Level = "A2",
                    Slug = "min-familj-och-vara-traditioner"
                },

                new Text
                {
                    Id = 7,
                    TextTitle = "Linas söndag",
                    LanguageText = "På söndagar behöver jag inte ställa någon väckarklocka. Jag brukar vakna vid nio och ligger kvar i sängen en stund innan jag går upp. Efter en lång dusch gör jag frukost – oftast yoghurt med bär och en kopp te.\r\n\r\nVid elva går jag ut på en promenad i parken. Jag gillar att lyssna på musik eller en podcast medan jag går. Ibland möter jag min vän Julia där, och då går vi tillsammans och pratar om veckan som har gått.\r\n\r\nEfter promenaden handlar jag mat. Jag planerar ofta veckans middagar redan på söndagen. Jag gillar att laga mat, så jag väljer gärna nya recept att prova.\r\n\r\nPå eftermiddagen brukar jag städa lägenheten och tvätta kläder. Det är inte så roligt, men det känns skönt när allt är rent och i ordning.\r\n\r\nPå kvällen lagar jag något gott och ser en film eller läser en bok. Jag försöker gå och lägga mig tidigt för att vara pigg till måndag morgon.",
                    Language = "Swedish",
                    Level = "A2",
                    Slug = "linas-sondag"
                },

                new Text
                {
                    Id = 8,
                    TextTitle = "Mitt rum i lägenheten",
                    LanguageText = "Jag bor i en liten lägenhet i stan. Jag har ett eget rum som är ganska litet, men det är mysigt och trivsamt. I mitt rum finns en enkelsäng, ett skrivbord, en stol och en bokhylla där jag har mina böcker och några foton.\r\n\r\nRummet har ett stort fönster som släpper in mycket ljus på dagen. Under fönstret står en liten soffa där jag ofta sitter och läser eller lyssnar på musik.\r\n\r\nJag har också några växter på fönsterbrädan. Min favoritväxt är en liten kaktus som är lätt att ta hand om.\r\n\r\nDet jag tycker bäst om med mitt rum är de gröna väggarna och att det är tyst där, så jag kan koncentrera mig när jag pluggar eller skriver. På kvällarna tänder jag en liten lampa som ger ett varmt och skönt ljus.",
                    Language = "Swedish",
                    Level = "A2",
                    Slug = "mitt-rum-i-lagenheten"
                },

                new Text
                {
                    Id = 9,
                    TextTitle = "Erik skriver ett personligt brev",
                    LanguageText = "Hej!\r\n\r\nJag heter Erik och jag är 28 år. Jag bor i Göteborg tillsammans med min sambo. På fritiden gillar jag att spela fotboll, läsa böcker och resa.\r\n\r\nJag vill gärna söka jobbet som kundserviceassistent hos er. Jag tycker om att hjälpa människor och lösa problem. Jag är också van vid att arbeta i team och har goda kommunikationsfärdigheter. Mina styrkor är att jag är tålamodig, ansvarsfull och noggrann. Jag är van vid att använda olika datorprogram och lär mig snabbt nya system.\r\n\r\nTidigare har jag arbetat på ett callcenter där jag hjälpte kunder med deras frågor och beställningar. Det var ofta hektiskt, men jag lärde mig att hantera stress och hålla ett vänligt bemötande även i svåra situationer.\r\n\r\nJag tror att mina erfarenheter och min personlighet passar bra för tjänsten hos er. Jag ser fram emot möjligheten att träffa er för en intervju.\r\n\r\nTack för er tid!\r\n\r\nMed vänlig hälsning,\r\nErik",
                    Language = "Swedish",
                    Level = "B1",
                    Slug = "erik-skriver-ett-personligt-brev"
                },

                new Text
                {
                    Id = 10,
                    TextTitle = "Min garderob",
                    LanguageText = "I mitt sovrum finns en ganska stor garderob där jag förvarar alla mina kläder. Jag har många tröjor, särskilt hoodies, eftersom jag tycker det är bekvämt och varmt. Min favorithoodie är mörkblå och har en stor ficka fram där jag kan stoppa händerna.\r\n\r\nJag har också flera skjortor, både kortärmade och långärmade. De flesta är i neutrala färger som vit, grå och svart, men jag har några med mönster också. Mina favoritbyxor är ett par svarta jeans som jag använder nästan varje dag. Jag har också några chinos i olika färger, till exempel beige och mörkgrön.\r\n\r\nI garderoben hänger mina jackor och rockar. På vintern använder jag en tjock svart vinterjacka med luva, och på hösten har jag en lättare regnjacka. Jag brukar lägga mina mössor, vantar och halsdukar på en hylla högst upp.\r\n\r\nJag försöker alltid hålla ordning i min garderob, så att jag snabbt kan hitta det jag behöver. Det gör det enklare att välja kläder på morgonen.",
                    Language = "Swedish",
                    Level = "B1",
                    Slug = "min-garderob"
                },

                new Text
                {
                    Id = 11,
                    TextTitle = "Göteborg",
                    LanguageText = "I helgen åkte jag och min vän Sara till Göteborg. Det är Sveriges näst största stad och ligger vid västkusten. Vi hade planerat att stanna i tre dagar för att upptäcka staden och njuta av den friska havsluften.\r\n\r\nDet som vi tycker är bäst med Göteborg är de fina parkerna och närheten till havet. Vi promenerade mycket i Slottsskogen, där det finns många djur och stora grönområden. Det var skönt att komma bort från stadens brus en stund.\r\n\r\nVi besökte också Avenyn, stadens stora huvudgata, där det finns många butiker, restauranger och kaféer. På kvällen åt vi middag på en liten fiskrestaurang vid hamnen. Maten var färsk och väldigt god.\r\n\r\nEn dag åkte vi till Liseberg, nöjesparken som är väldigt populär både bland barn och vuxna. Vi åkte karuseller, spelade på lyckohjul och åt sockervadd. Det var en rolig och lite annorlunda upplevelse.\r\n\r\nInnan vi åkte hem planerade vi redan nästa resa till Göteborg – för det finns så mycket mer att upptäcka!",
                    Language = "Swedish",
                    Level = "B1",
                    Slug = "goteborg"
                },

                new Text
                {
                    Id = 12,
                    TextTitle = "Sara och Erik bokar en resa",
                    LanguageText = "Reseagent: Hej och välkomna till Resebyrån! Hur kan jag hjälpa er idag?\r\nSara: Hej! Vi vill boka en resa till Italien i sommar. Finns det några bra erbjudanden?\r\nReseagent: Ja, vi har flera paketresor. Vill ni flyga till Rom, Milano eller kanske Neapel?\r\nErik: Vi tänkte mest på Rom. Hur länge kan vi stanna?\r\nReseagent: Det finns paket för en vecka eller två veckor. Vilket föredrar ni?\r\nSara: En vecka räcker för oss. Hur mycket kostar det per person?\r\nReseagent: Priset för en vecka i juli är 7000 kronor per person, inklusive flyg och hotell.\r\nErik: Kan vi boka ett hotell med frukost?\r\nReseagent: Självklart, alla våra paket inkluderar frukost. Vill ni ha ett rum med havsutsikt?\r\nSara: Ja, gärna! Det låter perfekt.\r\nReseagent: Då bokar jag en vecka i juli med frukost och havsutsikt. Vill ni även hyra bil?\r\nErik: Nej, vi tänker mest promenera och åka tunnelbana.\r\nReseagent: Bra val. Jag skriver ut bokningsbekräftelsen här. Tack för att ni valde oss!",
                    Language = "Swedish",
                    Level = "B1",
                    Slug = "sara-och-erik-bokar-en-resa"
                },

                new Text
                {
                    Id = 13,
                    TextTitle = "Familjen Eriksson på botaniska trädgården",
                    LanguageText = "Familjen Eriksson älskar natur och de försöker besöka den botaniska trädgården varje helg när vädret är fint.\r\n\r\nSofia fascineras mest av orkidéerna. Hon tycker att deras färger och former är otroligt vackra och hon läser alltid informationen om varje art noggrant. En gång fick hon se en ovanlig orkidé som bara blommar en gång om året, och hon blev väldigt glad.\r\n\r\nJohan är mest intresserad av de stora ekarna och andra gamla träd i trädgården. Han tycker om att sitta under deras skugga och lyssna på fåglarna som sjunger i grenarna ovanför. Han brukar också fotografera träden för sitt fotoprojekt i skolan.\r\n\r\nMamma Maria älskar den japanska delen av trädgården, där det finns små dammar, stenbroar och vackra körsbärsträd. Hon njuter alltid av att promenera långsamt där och ta många bilder.\r\n\r\nPappa Anders är fascinerad av trädgårdens växthus där tropiska växter och kaktusar växer. Han kan stå länge och studera de ovanliga växterna och försöka lära sig mer om dem. Han gillar särskilt hur olika växter anpassar sig till olika klimat.\r\n\r\nEfter en lång promenad i trädgården brukar familjen sätta sig vid caféet och fika tillsammans. Det är deras favoritstund på helgen — att prata om vad de sett och planera nästa besök.",
                    Language = "Swedish",
                    Level = "B2",
                    Slug = "familjen-eriksson-pa-botaniska-tradgarden"

                },

                new Text
                {
                    Id = 14,
                    TextTitle = "Kladdkakans dag i Sverige",
                    LanguageText = "Svenskar älskar att fika! I Sverige har bakverken sina egna dagar då de firas. Det finns en dag för kanelbullen, för wienerbrödet och för den kanske populäraste kakan – kladdkakan! Kladdkakans dag firas den 7e november varje år. Det är en söt, kladdig och god chokladkaka som nästan alla tycker om. Prova gärna att baka en kladdkaka med detta recept:\r\n\r\nSätt ugnen på 200 °C (grader).\r\n\r\nBlanda dessa ingredienser i en bunke:\r\n\r\n- 100 gram smör\r\n- 2 stycken ägg\r\n- 2 ½ deciliter socker\r\n- 3 matskedar kakao\r\n- 2 teskedar vaniljsocker\r\n- 1 ½ deciliter vetemjöl\r\n- 1 kryddmått salt\r\n\r\nHäll smeten i en form och ställ in den i ugnen. Kakan ska gräddas i cirka 10–15 minuter. Ju kortare tid, desto kladdigare. Du kan servera kakan med vad som helst: färska bär, grädde eller kanske glass – du bestämmer!",
                    Language = "Swedish",
                    Level = "B2",
                    Slug = "kladdkakans-dag-i-sverige"
                },

                new Text
                {
                    Id = 15,
                    TextTitle = "Spelens värld – mer än bara underhållning",
                    LanguageText = "Spel har utvecklats enormt under de senaste decennierna och har idag en viktig plats i många människors liv. Förutom att vara en källa till underhållning har spel också blivit en plattform för social samvaro, kreativitet och lärande.\r\n\r\nMånga uppskattar multiplayer-spel där man kan spela tillsammans med vänner eller träffa nya människor online. Genom att samarbeta eller tävla i olika spel lär man sig strategiskt tänkande, kommunikation och lagarbete. Det finns också spel som erbjuder en möjlighet att utforska fantasivärldar och berättelser på ett sätt som andra medier inte kan.\r\n\r\nE-sport har blivit en global företeelse där professionella spelare tävlar om stora prispengar och där miljontals tittare följer turneringarna via streamingtjänster. Detta har gett spel en status som en seriös sport, vilket bidrar till att förändra hur samhället ser på gaming.\r\n\r\nDet finns också en del kritik mot spel, särskilt när det gäller spelberoende och den tid många ungdomar tillbringar framför skärmarna. Det är därför viktigt att hitta en balans och att se till att spelandet inte påverkar andra delar av livet negativt.\r\n\r\nFör många är spel mer än bara en hobby – det är en passion och en gemenskap. Spelindustrin fortsätter att växa och utvecklas, och framtiden ser spännande ut med ny teknik som virtual reality och artificiell intelligens som integreras i spelupplevelsen.",
                    Language = "Swedish",
                    Level = "B2",
                    Slug = "spelens-varld-mer-an-bara-underhallning"
                },

                new Text
                {
                    Id = 16,
                    TextTitle = "Svensk natur är som en sagovärld",
                    LanguageText = "Jag heter Elin och jag är åtta år gammal. Idag är jag i en nationalpark tillsammans med min familj. När jag går här bland träden känns det nästan som om jag har klivit in i en saga. Den svenska naturen är så vacker och rogivande, och jag vill berätta om allt jag ser och känner.\r\n\r\nSkogen är tät och full av höga granar och björkar. Solen strilar ner genom grenarna och gör små fläckar av ljus på marken. Jag hör fåglarna sjunga och ibland ser jag en liten ekorre som snabbt hoppar från gren till gren. Det känns som att hela skogen lever och andas.\r\n\r\nVi går längs en stig som leder fram till en glittrande sjö. Vattnet är så klart att jag kan se fiskarna simma nära ytan. Runt sjön finns mjuka mossor och blommor i alla möjliga färger. Jag plockar en liten blå blomma och sätter den i mitt hår.\r\n\r\nDet bästa med att vara här är att luften är så frisk och doftar av tall och jord. Jag känner mig lugn och glad när jag är ute i naturen. Mamma säger att vi måste ta hand om vår natur, för den är en skatt som vi alla behöver bevara.\r\n\r\nJag vill aldrig lämna den här platsen, för svensk natur är verkligen något alldeles speciellt.",
                    Language = "Swedish",
                    Level = "B2",
                    Slug = "svensk-natur-ar-som-en-sagovard"

                },

                new Text
                {
                    Id = 17,
                    TextTitle = "Mój najlepszy przyjaciel",
                    LanguageText = "Mam na imię Kuba i mam najlepszego przyjaciela. Nazywa się Tomek. Znamy się od dzieciństwa. Mieszkamy na tej samej ulicy i chodzimy razem do szkoły.\r\n\r\nTomek ma krótkie blond włosy i niebieskie oczy. Lubi grać w piłkę nożną i słuchać muzyki. Często gramy razem na komputerze.\r\n\r\nPo szkole spotykamy się w parku albo robimy zadania domowe razem. Tomek jest miły, zabawny i zawsze mi pomaga.\r\n\r\nCieszę się, że mam takiego przyjaciela!",
                    Language = "Polish",
                    Level = "A1",
                    Slug = "moj-najlepszy-przyjaciel"
                },

                new Text
                {
                    Id = 18,
                    TextTitle = "Mój dzień",
                    LanguageText = "Mam na imię Ola. Mam 20 lat i mieszkam w Krakowie. Każdego dnia wstaję o godzinie 7:00. Myję się, ubieram i jem śniadanie. Na śniadanie lubię jeść chleb z serem albo jajko na twardo. Zawsze piję herbatę, a czasem kawę.\r\n\r\nO 7:30 wychodzę z domu i idę na uczelnię. Mieszkam blisko, więc idę pieszo. Zajęcia zaczynają się o 8:00 i kończą się o 14:00. Studiuję psychologię i bardzo lubię moje studia.\r\n\r\nPo zajęciach wracam do domu i jem obiad. Najczęściej jem zupę i makaron albo ryż z warzywami. Potem odpoczywam, słucham muzyki lub rozmawiam z przyjaciółmi przez telefon.\r\n\r\nWieczorem często spaceruję po parku albo oglądam film. Lubię też czytać książki, zwłaszcza powieści i kryminały.\r\n\r\nKładę się spać o 22:30, bo rano muszę wcześnie wstać. Lubię mój dzień, bo jest spokojny i dobrze zorganizowany.",
                    Language = "Polish",
                    Level = "A1",
                    Slug = "moj-dzien"
                },

                new Text
                {
                    Id = 19,
                    TextTitle = "Polskie jedzenie",
                    LanguageText = "W Polsce jest dużo smacznego jedzenia. Polacy lubią jeść zupy, mięso i ziemniaki. Popularne zupy to rosół, żurek i pomidorowa. Rosół to zupa z kurczakiem, marchewką i makaronem. Jest bardzo popularna w niedzielę.\r\n\r\nNa obiad Polacy często jedzą kotlet schabowy z ziemniakami i kapustą. To jest panierowane mięso, smażone na patelni. Jest bardzo pyszne!\r\n\r\nNa deser Polacy lubią pączki, sernik i szarlotkę. Pączek to słodkie ciastko z marmoladą w środku i cukrem pudrem na górze.\r\n\r\nW Polsce popularne są też pierogi. Są z różnym nadzieniem: z mięsem, z kapustą i grzybami, albo na słodko – z truskawkami lub serem.\r\n\r\nPolskie jedzenie jest ciepłe, sycące i smaczne. Bardzo je lubię!",
                    Language = "Polish",
                    Level = "A1",
                    Slug = "polskie-jedzenie"
                },

                new Text
                {
                    Id = 20,
                    TextTitle = "Po szkole gram w Minecrafta",
                    LanguageText = "Mam na imię Kuba i mam 10 lat. Mieszkam w Warszawie z mamą, tatą i młodszą siostrą. Chodzę do szkoły od poniedziałku do piątku. Lekcje zaczynają się o ósmej i kończą o czternastej.\r\n\r\nPo szkole jem obiad, odrabiam lekcje i potem mam czas wolny. Lubię grać w Minecrafta. To jest moja ulubiona gra! W Minecraftcie mogę budować domy, kopalnie i mosty. Czasem gram sam, a czasem z kolegami przez internet.\r\n\r\nNajbardziej lubię tryb kreatywny, bo mogę budować wszystko, co chcę. Mam też kota w grze i dużo diamentów. Granie w Minecrafta sprawia mi dużo radości!\r\n\r\nW weekendy mogę grać dłużej. To jest bardzo fajne!",
                    Language = "Polish",
                    Level = "A1",
                    Slug = "po-szkole-gram-w-minecrafta"
                },

                new Text
                {
                    Id = 21,
                    TextTitle = "Urodziny Ani",
                    LanguageText = "Kiedy zbliża się listopad, Ania zaczyna się bardzo cieszyć. Dlaczego? Bo w listopadzie ma urodziny! To jej ulubiony miesiąc, bo wtedy może świętować razem z rodziną i przyjaciółmi.\r\n\r\nAnia zawsze planuje swoje urodziny wcześniej. Zaczyna od robienia listy gości. Zawsze zaprasza mamę, tatę, starszego brata i młodszą kuzynkę Zosię. Nie może też zabraknąć jej najlepszej przyjaciółki Kasi, z którą chodzi do tej samej klasy.\r\n\r\nCo roku Ania wybiera temat przewodni przyjęcia. W zeszłym roku były to księżniczki, a w tym roku Ania chce, żeby wszystko było w kolorze niebieskim, bo to jej ulubiony kolor. Dekoracje, balony i nawet serwetki mają być niebieskie!\r\n\r\nNajważniejszy na przyjęciu jest oczywiście tort. Mama zawsze piecze go sama. Ania pomaga przy dekoracji – dodaje kolorową posypkę i układa świeczki. W tym roku tort będzie waniliowy z truskawkowym kremem.\r\n\r\nPo zjedzeniu tortu wszyscy grają w gry – w chowanego, kalambury i czasem nawet w karaoke! Ania zawsze dostaje dużo prezentów, ale najbardziej cieszy się z tego, że może spędzić ten dzień z bliskimi osobami.",
                    Language = "Polish",
                    Level = "A2",
                    Slug = "urodziny-ani"
                },

                new Text
                {
                    Id = 22,
                    TextTitle = "Moje codzienne życie",
                    LanguageText = "Mam na imię Michał. Mam 28 lat i mieszkam w Krakowie. To piękne miasto na południu Polski. Mieszkam tutaj od pięciu lat. Wcześniej mieszkałem w małej wiosce, ale przeprowadziłem się do miasta, żeby studiować i pracować.\r\n\r\nMam siostrę, która mieszka w Gdańsku. Rzadko się widzimy, ale często rozmawiamy przez telefon. Moi rodzice nadal mieszkają na wsi. Czasem jadę tam w weekend, żeby ich odwiedzić. Mama zawsze gotuje coś pysznego, a tata pokazuje mi, co nowego zrobił w ogrodzie.\r\n\r\nPracuję jako grafik komputerowy. Lubię swoją pracę, bo mogę być kreatywny. Pracuję z domu, więc nie muszę codziennie jeździć do biura. To bardzo wygodne. W wolnym czasie rysuję, gram w gry komputerowe i spaceruję po mieście.\r\n\r\nMam psa, który nazywa się Fado. To duży, biały pies. Chodzimy razem na spacery rano i wieczorem. Fado bardzo lubi dzieci i inne psy. Wszyscy na osiedlu go znają i lubią.\r\n\r\nLubię też podróżować. W zeszłym roku byłem w Czechach i na Słowacji. W tym roku chciałbym pojechać do Włoch. Marzę o tym, żeby zobaczyć Rzym i zjeść prawdziwą włoską pizzę!",
                    Language = "Polish",
                    Level = "A2",
                    Slug = "moje-codzienne-zycie"
                },

                new Text
                {
                    Id = 23,
                    TextTitle = "Podróżowanie to przygoda",
                    LanguageText = "Lubię podróżować, bo każda podróż to nowa przygoda. Mam rower, samochód i czasem korzystam z pociągu albo autobusu. Lubię też długie spacery, zwłaszcza kiedy świeci słońce. Podczas podróży można zobaczyć coś nowego i poznać ciekawych ludzi.\r\n\r\nNajczęściej podróżuję po Polsce. Byłem już w wielu miastach, takich jak Kraków, Warszawa, Gdańsk i Wrocław. Każde miasto ma coś wyjątkowego. Ale nie tylko duże miasta są interesujące. Małe miasteczka i wsie też mają swój urok. Czasem są tam piękne kościoły, stare zamki albo malownicze parki.\r\n\r\nBardzo lubię jeździć nad morze. Słuchanie szumu fal i chodzenie boso po piasku to coś wspaniałego. Moje ulubione miejsca nad morzem to Ustka i Hel. Można tam łatwo dojechać pociągiem z wielu miejsc w Polsce.\r\n\r\nLubię też góry. W Tatrach byłem kilka razy. Wędrowałem po szlakach i podziwiałem widoki. Gdy ktoś chce zobaczyć piękne krajobrazy i poczuć świeże powietrze, powinien pojechać w góry. Ale uwaga – pogoda w górach zmienia się szybko, więc trzeba być przygotowanym.\r\n\r\nNie trzeba jednak jechać daleko, żeby coś przeżyć. Czasem wystarczy wyjść z domu i pójść do pobliskiego lasu lub parku. Przyroda jest wszędzie – wystarczy tylko rozejrzeć się uważnie.\r\n\r\nA Ty? Gdzie najbardziej lubisz podróżować? Może spotkamy się kiedyś w drodze?",
                    Language = "Polish",
                    Level = "A2",
                    Slug = "podrozowanie-to-przygoda"
                },

                new Text
                {
                    Id = 24,
                    TextTitle = "Czas wolny mojej rodziny",
                    LanguageText = "Mam na imię Bartek. Mam 15 lat i chodzę do szkoły średniej. W wolnym czasie lubię grać na komputerze. Moją ulubioną grą jest Minecraft. Buduję tam domy, miasta, a czasem całe wyspy. Lubię też słuchać muzyki – najczęściej rocka i popu. Wieczorami często czytam książki o przygodach lub science fiction.\r\n\r\nMój młodszy brat Krzyś ma 10 lat. Bardzo lubi rysować. Ma dużo kolorowych kredek i markerów. Rysuje zwierzęta, samochody i postacie z bajek. Czasem razem gramy w gry planszowe albo budujemy coś z klocków LEGO. Krzyś nie lubi grać w gry komputerowe – mówi, że go męczą.\r\n\r\nNasza mama, pani Magda, uwielbia gotować. W weekendy próbuje nowe przepisy. Ostatnio piekła pizzę domową i robiła naleśniki z owocami. Cała rodzina je razem kolację. To dla nas ważny moment dnia.\r\n\r\nTata, pan Andrzej, często biega. Bierze udział w zawodach i trenuje kilka razy w tygodniu. W wolnym czasie lubi też czytać książki historyczne. Wie dużo o dawnych czasach i czasem opowiada nam ciekawe historie.\r\n\r\nCzasami w niedzielę wychodzimy razem na wycieczkę. Jeździmy do lasu, do zoo albo nad jezioro. Robimy zdjęcia i jemy kanapki na ławce. Lubię te chwile z rodziną. A Ty, jak spędzasz wolny czas?",
                    Language = "Polish",
                    Level = "A2",
                    Slug = "czas-wolny-mojej-rodziny"
                },

                new Text
                {
                    Id = 25,
                    TextTitle = "Studia za granicą",
                    LanguageText = "Kasia od zawsze marzyła o studiowaniu za granicą. Już w liceum interesowała się kulturą innych krajów i chętnie uczyła się języków obcych. Po zdaniu matury postanowiła, że spróbuje swoich sił na zagranicznym uniwersytecie. Chciała nie tylko zdobyć dobrą edukację, ale także poznać nowych ludzi i rozwinąć się jako osoba.\r\n\r\nWybór kraju nie był prosty. Kasia brała pod uwagę Niemcy, Holandię i Szwecję. Wszystkie te kraje oferują programy studiów w języku angielskim, a dodatkowo mają dobrą reputację, jeśli chodzi o jakość nauczania. Ostatecznie wybrała Szwecję, ponieważ bardzo podobała jej się przyroda i styl życia mieszkańców.\r\n\r\nStudia za granicą to nie tylko nauka. Trzeba było załatwić wiele formalności – między innymi aplikować o wizę, znaleźć mieszkanie i zapisać się na kursy. Początki były trudne. Kasia nie znała nikogo w nowym miejscu, tęskniła za rodziną i musiała przyzwyczaić się do innego systemu nauczania.\r\n\r\nZ czasem jednak wszystko się zmieniło. Kasia poznała przyjaciół z różnych krajów, zaczęła mówić coraz lepiej po angielsku, a nawet uczyła się trochę szwedzkiego. Nauczyła się gotować, zarządzać swoim budżetem i być bardziej samodzielna. Dzisiaj uważa, że wyjazd na studia był jedną z najlepszych decyzji w jej życiu.\r\n\r\nStudia za granicą to duże wyzwanie, ale też ogromna szansa. Dzięki nim można nie tylko zdobyć wykształcenie, ale też lepiej poznać siebie i świat.",
                    Language = "Polish",
                    Level = "B1",
                    Slug = "studia-za-granica"
                },

                new Text
                {
                    Id = 26,
                    TextTitle = "Gdzie mieszkam",
                    LanguageText = "Mieszkam w centrum Europy – w Polsce. Ale zgadnijcie, w jakim mieście dokładnie? Poniżej znajdziecie kilka wskazówek, które pomogą Wam odgadnąć tę tajemnicę.\r\n\r\nMoje miasto jest czwartym co do wielkości w Polsce, jeśli chodzi o liczbę mieszkańców. Można tu znaleźć miejsca, które mają takie same nazwy jak znane miejsca na świecie – na przykład Kilimandżaro czy Morskie Oko. Bardzo popularna jest również Fontanna Multimedialna, która znajduje się w pobliżu Hali Stulecia.\r\n\r\nJeszcze kilkadziesiąt lat temu to miasto nie było częścią Polski. Znajduje się tutaj wiele mostów, rzek i małych wysp. Przez centrum przepływa rzeka, a wokół starego miasta wciąż działa fosa, w której cały czas jest woda. Z mojego miasta bliżej jest do Berlina, stolicy Niemiec, niż do Warszawy – stolicy Polski.\r\n\r\nMiasto cieszy się ogromną popularnością wśród turystów – co roku odwiedzają je miliony osób. Wielu z nich zagląda do naszego znanego ZOO. Jedną z największych atrakcji jest Afrykarium, gdzie można oglądać egzotyczne zwierzęta w warunkach bardzo zbliżonych do naturalnych.\r\n\r\nMiłośnicy kultury także nie będą się nudzić – znajdą tu wiele teatrów, muzeów i kin. W 2016 roku miasto zostało Europejską Stolicą Kultury i Światową Stolicą Książki.\r\n\r\nCzy potrzebujecie jeszcze jednej wskazówki? Dobrze, oto ostatnia: łacińska nazwa tego miasta to Vratislavia, a po niemiecku nazywa się Breslau. Już wiecie? Tak, to Wrocław!",
                    Language = "Polish",
                    Level = "B1",
                    Slug = "gdzie-mieszkam"
                },

                new Text
                {
                    Id = 27,
                    TextTitle = "Kolory",
                    LanguageText = "Cześć! Znowu się widzimy – mam na imię Ania i dzisiaj opowiem wam o kolorach, które lubię i których nie lubię. Od zawsze podobały mi się jasne i radosne kolory. Kiedy byłam mała, moimi ulubionymi kolorami były różowy, jasny niebieski i żółty. Mam zdjęcie z dzieciństwa, na którym mam na sobie różową sukienkę, jasnoniebieskie legginsy i żółte sandały. To jedno z moich najcenniejszych zdjęć!\r\n\r\nW wieku nastoletnim najbardziej lubiłam kolor czerwony – do dziś mam moją czerwoną sukienkę, w której chodziłam na wszystkie ważne uroczystości. Kiedy zaczęłam studia, polubiłam też pomarańczowy i jasną zieleń. Mam zielony szalik, rękawiczki i czapkę, które noszę zimą. Oprócz tego podobają mi się kolory takie jak biały, złoty i srebrny. Teraz moim ulubionym kolorem jest zielony, ale kto wie – może za kilka lat polubię fioletowy albo błękitny?\r\n\r\nNie przepadam za ciemnymi i smutnymi kolorami, na przykład czarnym, brązowym, szarym, granatowym czy ciemnozielonym. Raczej nie kupuję ubrań w takich kolorach. Mój pokój też jest urządzony w jasnych barwach – ciemnych kolorów jest w nim bardzo mało. Czasami jednak zakładam czarne lub szare rajstopy, bo pasują do wszystkiego. Mam też kilka dodatków – kolczyki, bransoletki i naszyjniki – w brązowych i srebrnych odcieniach. Ale jeśli chodzi o ubrania, to ciemne kolory są prawie nieobecne w mojej szafie.",
                    Language = "Polish",
                    Level = "B1",
                    Slug = "kolory"
                },

                new Text
                {
                    Id = 28,
                    TextTitle = "Zakupy",
                    LanguageText = "Idę na zakupy. Moja dziewczyna Lila poprosiła mnie, żebym kupił wszystko na jej urodzinową kolację. Planuje duże przyjęcie – zaprosiła aż trzynaście osób. Lista zakupów jest długa, ale na szczęście wszystko mam zapisane.\r\n\r\nLila chce przygotować lasagne, więc muszę kupić sześć opakowań makaronu do lasagne i osiem puszek pomidorów. Potrzebne są też cztery cebule, czosnek i świeża bazylia. Do tego kupię też ser i trochę oliwy z oliwek.\r\n\r\nNa przystawkę Lila robi sałatkę grecką. Muszę kupić trzy ogórki, kilka pomidorów, dwa opakowania sera feta i oliwki. Do sosu mam kupić jeden jogurt naturalny i trochę przypraw.\r\n\r\nPrzyjęcie nie może się obyć bez przekąsek. Goście bardzo lubią słone rzeczy, więc biorę dziesięć paczek chipsów, sześć paczek krakersów i siedem paczek orzeszków. Dla dzieci kupiłem też trzy paczki żelków.\r\n\r\nNa deser będzie ciasto owocowe i sałatka owocowa. Kupiłem dwanaście bananów, piętnaście jabłek, osiem pomarańczy, sześć kiwi i pięć opakowań malin. Wszystko razem będzie bardzo kolorowe i smaczne.\r\n\r\nZostały mi już tylko napoje do kupienia. Wezmę dwadzieścia cztery puszki napojów gazowanych, dwadzieścia piw i trzy butelki wina. Mam jeszcze dziewięćdziesiąt złotych, więc kupię jedną butelkę szampana i tort waniliowy – to ulubiony smak Lili. Mam nadzieję, że impreza będzie udana!",
                    Language = "Polish",
                    Level = "B1",
                    Slug = "zakupy"
                },

                new Text
                {
                    Id = 29,
                    TextTitle = "Ciało",
                    LanguageText = "Cześć! Mam na imię Ania i mam dwadzieścia pięć lat. Dzisiaj opowiem wam o tym, jak wyglądam. Wiele osób nie jest zadowolonych ze swojego wyglądu ale ja lubię moje ciało.\r\n\r\nMam małą głowę. Moje włosy są długie i proste. Jestem brunetką. Moje oczy są duże i zielone. Mam gęste brwi i krótkie proste rzęsy. Mój nos jest długi i prosty. Mam pełne duże usta i proste białe zęby. Mam podwójny podbródek. Mam owalną twarz i jasną karnację. W lecie na mojej skórze widać piegi.\r\n\r\nMoja szyja jest długa i zgrabnie połączona z klatką piersiową. Moje plecy są proste a mój brzuch, ramiona i nogi są szczupłe i umięśnione. Jestem wysoka i smukła. Nie mam nadwagi lecz nie jestem również chuda. Jestem młoda więc moje barki, łokcie, dłonie i palce poruszają się sprawnie i bez problemów. Moje kolana nigdy mnie nie bolą. Moje stopy i kostki u nóg nigdy nie puchną. Czasami bolą mnie palce u stóp - szczególnie wtedy, kiedy noszę buty na wysokim obcasie. Bardzo o siebie dbam - zdrowo się odżywiam i uprawiam sport. Dlatego mam nadzieję że mój mózg, moje płuca, serce, wątroba, żołądek, nerki i jelita będą jak najdłużej sprawnie funkcjonować.",
                    Language = "Polish",
                    Level = "B2",
                    Slug = "cialo"
                },

                new Text
                {
                    Id = 30,
                    TextTitle = "Podróż do Chin",
                    LanguageText = "Mam na imię Marta, mam dwadzieścia sześć lat i pochodzę z Krakowa. Od zawsze interesowałam się kulturą azjatycką, a szczególnie fascynowały mnie Chiny – ich historia, kuchnia, język i tradycje. Dlatego rok temu postanowiłam zrealizować moje marzenie i pojechałam tam na trzy miesiące.\r\n\r\nPodróż rozpoczęłam w Pekinie. Miasto zrobiło na mnie ogromne wrażenie – było głośne, tętniące życiem i pełne kontrastów. Z jednej strony nowoczesne wieżowce, z drugiej – tradycyjne świątynie i wąskie uliczki hutongów. Odwiedziłam Zakazane Miasto, spacerowałam po Wielkim Murze Chińskim i próbowałam lokalnych potraw, takich jak kacza po pekińsku i pierożki dim sum.\r\n\r\nPo tygodniu ruszyłam do Xi’an, gdzie mogłam zobaczyć słynną armię terakotową. Następnie poleciałam do Chengdu – miasta znanego z pand. W centrum badań i ochrony pand mogłam zobaczyć te zwierzęta z bliska, co było niesamowitym przeżyciem.\r\n\r\nOstatni miesiąc spędziłam w Szanghaju, gdzie pracowałam jako wolontariuszka w szkole językowej. Uczyłam dzieci podstaw angielskiego, a one pomagały mi w nauce chińskiego. Dzięki temu mogłam naprawdę zanurzyć się w codzienne życie mieszkańców.\r\n\r\nChińska kultura bardzo różni się od polskiej, ale właśnie to było dla mnie najciekawsze. Musiałam nauczyć się nowych zasad – na przykład tego, że w Chinach nie zostawia się napiwków albo że hałas w restauracjach jest czymś zupełnie normalnym.\r\n\r\nPodróż do Chin była dla mnie ogromną przygodą i doświadczeniem, które zmieniło moje spojrzenie na świat. Nauczyłam się nie tylko nowych rzeczy o innym kraju, ale też wiele o sobie samej. Marzę o tym, żeby tam wrócić – tym razem na dłużej.",
                    Language = "Polish",
                    Level = "B2",
                    Slug = "podroz-do-chin"
                },

                new Text
                {
                    Id = 31,
                    TextTitle = "Miasto czy wieś?",
                    LanguageText = "Od zawsze trwa dyskusja na temat tego, gdzie lepiej mieszkać – w mieście czy na wsi. Każde z tych miejsc ma swoje zalety i wady, a wybór często zależy od stylu życia, osobowości i priorytetów danej osoby.\r\n\r\nŻycie w mieście jest dynamiczne i pełne możliwości. Ludzie mieszkający w dużych miastach mają łatwiejszy dostęp do pracy, edukacji, kultury i rozrywki. Kino, teatr, siłownia, restauracja – wszystko jest na wyciągnięcie ręki. Komunikacja miejska umożliwia szybkie przemieszczanie się bez potrzeby posiadania własnego samochodu. Jednak życie w mieście wiąże się też z hałasem, stresem i zanieczyszczeniem powietrza. Często brakuje tam przestrzeni i kontaktu z naturą.\r\n\r\nZ drugiej strony, wieś oferuje ciszę, spokój i bliskość przyrody. Wiele osób decyduje się na przeprowadzkę na wieś, żeby zwolnić tempo życia i cieszyć się prostymi rzeczami – spacerem po lesie, śpiewem ptaków czy świeżym powietrzem. Ceny mieszkań na wsi są zwykle niższe niż w miastach, co pozwala na zakup większego domu z ogrodem. Jednak codzienne życie może być trudniejsze – szczególnie zimą, gdy do najbliższego sklepu lub lekarza trzeba jechać kilka kilometrów. Brakuje też wielu udogodnień, do których mieszkańcy miast są przyzwyczajeni.\r\n\r\nCoraz popularniejsze staje się rozwiązanie pośrednie – mieszkanie na obrzeżach miasta lub w małej miejscowości z dobrym dojazdem do dużego miasta. W ten sposób można korzystać z zalet obu światów – spokoju natury i wygody miejskiej infrastruktury.\r\n\r\nDla mnie najważniejsze jest, aby miejsce zamieszkania pasowało do mojego trybu życia i charakteru. Jedni potrzebują hałasu i ruchu, inni wolą ciszę i naturę. Niezależnie od wyboru, najważniejsze to czuć się dobrze tam, gdzie się mieszka.",
                    Language = "Polish",
                    Level = "B2",
                    Slug = "miasto-czy-wies"

                },

                new Text
                {
                    Id = 32,
                    TextTitle = "Kolacja we dwoje",
                    LanguageText = "W piątkowy wieczór Marta i Paweł postanowili wybrać się do restauracji. Oboje mieli za sobą intensywny tydzień pracy i uznali, że zasługują na chwilę relaksu i odrobinę luksusu. Zarezerwowali stolik w nowej włoskiej restauracji, która niedawno otworzyła się w centrum miasta. Słyszeli o niej wiele pozytywnych opinii i byli ciekawi, czy rzeczywiście jedzenie tam jest tak pyszne, jak wszyscy mówią.\r\n\r\nGdy weszli do lokalu, od razu poczuli przyjemny zapach ziół i świeżo pieczonego chleba. Wnętrze było eleganckie, ale jednocześnie przytulne. Kelner zaprowadził ich do stolika przy oknie. Złożyli zamówienie – Paweł wybrał tagliatelle z łososiem i szpinakiem, a Marta zdecydowała się na risotto z grzybami i parmezanem. Do tego zamówili butelkę czerwonego wina.\r\n\r\nPodczas kolacji rozmawiali o swoich planach na weekend, wspominali wspólne wakacje i śmiali się z drobnych codziennych sytuacji. Czas płynął szybko, a jedzenie rzeczywiście okazało się wyśmienite. Obsługa była uprzejma i profesjonalna, co dodatkowo wpłynęło na ich pozytywne wrażenia.\r\n\r\nNa deser zamówili tiramisu i panna cottę z malinowym sosem. Marta była zachwycona delikatnym smakiem i sposobem podania – deser wyglądał jak dzieło sztuki. Paweł zażartował, że chyba będą musieli częściej wychodzić do restauracji, skoro każde wyjście jest tak udane.\r\n\r\nWieczór zakończyli spacerem po oświetlonych uliczkach miasta. Oboje czuli się szczęśliwi i odprężeni. To była dla nich nie tylko pyszna kolacja, ale też ważny moment, kiedy mogli pobyć tylko we dwoje i na nowo poczuć bliskość w codziennym zabieganiu.",
                    Language = "Polish",
                    Level = "B2",
                    Slug = "kolacja-we-dwoje"
                },

                new Text
                {
                    Id = 33,
                    TextTitle = "Мой день",
                    LanguageText = "Меня зовут Лена. Мне восемь лет. Я живу в городе с мамой, папой и младшим братом. Каждый день я встаю в семь часов утра. Я умываюсь, одеваюсь и завтракаю. На завтрак я люблю есть хлеб с маслом и чай. Иногда мама готовит яичницу.\r\n\r\nПосле завтрака я иду в школу. Моя школа недалеко, я хожу туда пешком. Уроки начинаются в восемь тридцать. Я люблю математику и рисование. После школы я иду домой. Обед готовит папа. Он хорошо готовит суп и макароны.\r\n\r\nПосле обеда я делаю уроки, а потом играю с братом или смотрю мультфильмы. Вечером мы ужинаем всей семьёй. Мы разговариваем и смеёмся. Потом я чищу зубы и ложусь спать в девять часов.",
                    Language = "Russian",
                    Level = "A1",
                    Slug = "moy-den"
                },

                new Text
                {
                    Id = 34,
                    TextTitle = "Мой друг",
                    LanguageText = "Это мой лучший друг — Игорь. Ему десять лет. Он живёт рядом со мной, в том же доме, на втором этаже. У него большая семья: мама, папа, сестра и кот Барсик. Игорь любит спорт. Он играет в футбол каждый день после школы. Его любимая команда — «Зенит».\r\n\r\nКаждое утро Игорь встаёт в семь часов. Он умывается, завтракает и идёт в школу. Он хорошо учится и любит математику и физкультуру. У него есть рюкзак с машинками, а в пенале всегда есть линейка и цветные ручки.\r\n\r\nПосле школы мы играем во дворе, катаемся на велосипедах и иногда ходим в магазин за мороженым. Вечером Игорь делает уроки, а потом смотрит мультики с сестрой. Он ложится спать в девять часов.\r\n\r\nИгорь весёлый, добрый и всегда готов помочь. Я рад, что у меня есть такой друг!",
                    Language = "Russian",
                    Level = "A1",
                    Slug = "moy-drug"
                },

                new Text
                {
                    Id = 35,
                    TextTitle = "Путешествие в Москву",
                    LanguageText  = "Меня зовут Дима. Мне восемь лет. Летом я ездил в Москву с мамой, папой и сестрой Аней. Мы ехали на поезде. Поезд был большой и удобный. В дороге мы играли в игры, ели бутерброды и смотрели в окно.\r\n\r\nКогда мы приехали в Москву, мы пошли в гостиницу. Наша комната была светлая и большая. В первый день мы гуляли по Красной площади. Мы видели Кремль и собор Василия Блаженного. Было очень красиво!\r\n\r\nНа второй день мы ездили в Московский зоопарк. Там были тигры, слоны, жирафы и обезьяны. Мне очень понравился пингвин. Он был смешной!\r\n\r\nМы тоже катались на метро. В метро было много людей. Станции были красивые и большие.\r\n\r\nЯ рад, что мы поехали в Москву. Это было весёлое и интересное путешествие!",
                    Language = "Russian",
                    Level = "A1",
                    Slug = "puteshestvie-v-moskvu"
                },

                new Text
                {
                    Id = 36,
                    TextTitle = "Ищу работу",
                    LanguageText = "Меня зовут Ольга. Мне тридцать лет. Я живу в большом городе. Я хочу работать в школе. Я учительница русского языка. У меня есть диплом и опыт работы.\r\n\r\nСейчас у меня нет работы. Каждый день я ищу работу. Я читаю объявления в интернете и в газете. Я пишу резюме и отправляю письма в школы. Иногда я говорю по телефону с директором школы.\r\n\r\nНа этой неделе я была на собеседовании. Директор школы был добрый. Он сказал, что позвонит мне через два дня. Я надеюсь, что получу работу. Я люблю учить детей и работать в школе.\r\n\r\nЯ хочу быть хорошим учителем. Я читаю книги, готовлю уроки и учусь каждый день. Я верю, что скоро найду работу!",
                    Language = "Russian",
                    Level = "A1",
                    Slug = "ishu-rabotu"
                },

                new Text
                {
                    Id = 37,
                    TextTitle = "Мой питомец",
                    LanguageText = "С самого детства я мечтал о домашнем животном. Я хотел завести собаку, но мои родители говорили, что это большая ответственность. Поэтому сначала у меня был морской свинтус по имени Тоша. Он был маленький, очень пушистый и дружелюбный. У него была мягкая бело-серая шерсть. Мы купили для него просторную клетку с домиком и колесом. Я любил наблюдать, как он бегает и ест. Больше всего он любил яблоки и свежую капусту.\r\n\r\nКогда я стал взрослым и переехал в собственную квартиру, я наконец-то завёл собаку. Я выбрал породу хаски, потому что мне нравятся активные и умные собаки. Моего пса зовут Макс. Он серо-белый и у него голубые глаза. Мы с Максом гуляем утром и вечером. Он очень энергичный и дружелюбный. Я учу его разным командам — он уже умеет приносить мяч, садиться и даже давать лапу. Макс стал для меня настоящим другом и каждый день делает мою жизнь лучше.",
                    Language = "Russian",
                    Level = "A2",
                    Slug = "moy-pitomec"
                },

                new Text
                {
                    Id = 38,
                    TextTitle = "Мой распорядок дня",
                    LanguageText = "Обычно я просыпаюсь в половине седьмого утра. Сначала умываюсь, чищу зубы и принимаю душ. После этого я быстро делаю зарядку — примерно 10 минут, чтобы проснуться и почувствовать себя бодрым.\r\n\r\nЗавтрак у меня около семи. Я готовлю омлет с помидорами или грею гречку с овощами. Иногда пью кофе с молоком, но чаще — зелёный чай. Завтрак у меня короткий, около двадцати минут.\r\n\r\nВ восемь часов я начинаю собираться на работу. Одеваюсь, причесываюсь и собираю вещи. Обычно беру с собой рюкзак с ноутбуком, документами и бутылкой воды. В восемь тридцать выезжаю на машине.\r\n\r\nМой офис находится в центре города, и дорога занимает около часа. Я слушаю подкасты по дороге. Рабочий день начинается в девять тридцать. С десяти до одиннадцати у нас совещание. Потом я работаю над проектами до обеда. В столовой часто беру борщ, картофельное пюре и курицу. Иногда ем бутерброды с сыром и салат. Обед в час дня, длится около получаса.\r\n\r\nРабочий день заканчивается в шесть. Иногда после работы я иду в спортзал, особенно по понедельникам, средам и пятницам. Тренировка начинается в семь и длится до восьми. После этого я еду домой. Обычно бываю дома около девяти.\r\n\r\nУжин — что-то лёгкое: салат или суп. Потом немного отдыхаю, смотрю сериал или читаю книгу. Спать ложусь примерно в одиннадцать. Мне нравится такой режим — он помогает всё успевать.",
                    Language = "Russian",
                    Level = "A2",
                    Slug = "moy-rasporyadok-dnya"
                },

                new Text
                {
                    Id = 39,
                    TextTitle = "Путешествие в Сибирь",
                    LanguageText = "Меня зовут Артём. Мне двадцать семь лет, и я очень люблю путешествовать по России. Этой зимой я решил поехать в Сибирь. Я давно мечтал увидеть Байкал, тайгу и настоящую русскую зиму.\r\n\r\nСначала я прилетел в Иркутск. Город был покрыт снегом, на улице было минус двадцать градусов. Я надел тёплую куртку, шапку и варежки. Люди были добрые и улыбчивые. Я жил в гостинице недалеко от центра.\r\n\r\nНа второй день я поехал на экскурсию к озеру Байкал. Это было невероятно красиво! Лёд был прозрачный, и под ним можно было увидеть камни и трещины. Я даже попробовал кататься на коньках. Вечером мы ели рыбу и пили горячий чай у костра.\r\n\r\nПотом я поехал в небольшой город в тайге. Там я жил у местной семьи. Мы гуляли по лесу, видели следы животных и ели вкусные пирожки с капустой. Мне очень понравилась природа — всё было тихо и спокойно.\r\n\r\nСибирь — удивительное место. Я был там только одну неделю, но запомню это путешествие на всю жизнь. Я обязательно вернусь туда ещё раз, может быть летом.",
                    Language = "Russian",
                    Level = "A2",
                    Slug = "puteshestvie-v-sibir"
                }
                ,

                new Text
                {
                    Id = 40,
                    TextTitle = "Я — повар",
                    LanguageText = "Меня зовут Сергей, мне тридцать лет. Я живу в Санкт-Петербурге и работаю поваром в ресторане русской кухни. Я готовлю с детства. Моя бабушка учила меня печь пироги, варить борщ и делать блины. С тех пор я понял, что хочу стать поваром.\r\n\r\nКаждый день я прихожу на работу в десять утра. Сначала я проверяю продукты: мясо, рыбу, овощи и специи. Потом мы с командой начинаем готовить блюда на обед. Наш ресторан предлагает традиционные русские блюда: пельмени, щи, солянку, гречку с грибами и оливье. Особенно туристы любят борщ со сметаной и домашний хлеб.\r\n\r\nИногда я придумываю новые рецепты. Например, я сделал вареники с сыром и зеленью, и они стали популярными у гостей. Мне нравится, когда люди улыбаются и говорят, что еда вкусная. Это даёт мне мотивацию работать лучше.\r\n\r\nРабочий день заканчивается в восемь вечера. После работы я часто читаю книги о кухнях мира или смотрю кулинарные шоу. Моя мечта — открыть свой ресторан и учить молодых поваров. Я думаю, что готовить — это не просто работа, а искусство.",
                    Language = "Russian",
                    Level = "A2",
                    Slug = "ya-povar"
                },

                new Text
                {
                    Id = 41,
                    TextTitle = "Русская кухня",
                    LanguageText = "Русская кухня — одна из самых разнообразных и интересных в мире. В ней сочетаются старинные традиции, простые ингредиенты и уникальные вкусы.\r\n\r\nОснову русской кухни составляют блюда из картофеля, капусты, мяса, рыбы и круп, особенно гречки. Например, борщ — это знаменитый суп из свёклы, капусты и мяса, который подаётся со сметаной. Щи — ещё один популярный суп, приготовленный из квашеной капусты.\r\n\r\nНа завтрак русские часто едят кашу — овсяную, гречневую или манную. Также очень популярны блины с мёдом, вареньем или сметаной. В праздники пекут пироги с разной начинкой: мясом, грибами, картошкой, капустой или сладкими ягодами.\r\n\r\nНа ужин обычно подают горячее блюдо: жареную картошку, котлеты, рыбу или плов. В деревнях до сих пор готовят в русской печи, придавая блюдам особый вкус.\r\n\r\nОсобенное место в русской кухне занимает чай. Его пьют в любое время дня, часто с вареньем, печеньем или пряниками. Самовар — символ русского чаепития.\r\n\r\nРусская кухня — это часть культуры и истории страны. Она объединяет людей за одним столом и передаётся из поколения в поколение.",
                    Language = "Russian",
                    Level = "B1",
                    Slug = "russkaya-kuhnya"
                },

                new Text
                {
                    Id = 42,
                    TextTitle = "Моё утро",
                    LanguageText = "Я просыпаюсь очень рано — в шесть утра — по звонку будильника. Сначала я заправляю кровать, умываюсь, чищу зубы и готовлю себе завтрак. Обычно я предпочитаю плотный и сытный завтрак, чтобы энергии хватило на весь день. Сегодня я приготовил яичницу с беконом и сделал бутерброд с сыром. По утрам я всегда пью чёрный бодрящий кофе. Я не люблю сладкое, поэтому никогда не добавляю сахар.\r\n\r\nПосле завтрака я одеваюсь и выхожу на прогулку с собакой. Мы гуляем в ближайшем парке. Там я делаю лёгкую зарядку: растягиваюсь, делаю пару упражнений и дышу свежим воздухом. Это помогает проснуться и настроиться на рабочий день.\r\n\r\nПотом я возвращаюсь домой, собираю сумку и иду на работу. Я работаю недалеко от дома, продавцом в продуктовом магазине. Мне очень удобно, потому что не нужно тратить много времени на дорогу в метро или стоять в пробках. В девять утра я прихожу на работу, здороваюсь с коллегами и начинаю свой рабочий день.",
                    Language = "Russian",
                    Level = "B1",
                    Slug = "moyo-utro"
                },

                new Text
                {
                    Id = 43,
                    TextTitle = "О себе",
                    LanguageText = "Меня зовут Артём. Мне семнадцать лет. Я живу в России, в городе Екатеринбург. Это большой и красивый город на Урале.\r\n\r\nДва года назад мы с родителями переехали в новый район. Теперь мы живём на улице Ленина, дом 24, квартира 12. Наш дом рядом с парком, и я часто гуляю там с друзьями. Мы катаемся на велосипедах, играем в футбол и просто болтаем. Недавно я начал заниматься скейтбордингом — это моё новое хобби.\r\n\r\nВ моей семье четверо человек: мама, папа, я и моя младшая сестра Лиза. Ей девять лет. Я хорошо с ней лажу, иногда помогаю делать уроки. Мы с папой любим смотреть футбол по выходным, а с мамой я часто готовлю ужин — особенно пасту и салаты.\r\n\r\nЯ учусь в выпускном классе. В будущем хочу стать архитектором. Мне нравится рисовать, проектировать здания и узнавать больше о современных технологиях. Надеюсь, что поступлю в хороший университет и стану настоящим специалистом.",
                    Language = "Russian",
                    Level = "B1",
                    Slug = "o-sebe"
                },

                new Text
                {
                    Id = 44,
                    TextTitle = "Незабываемые выходные в Санкт-Петербурге",
                    LanguageText = "В прошлые выходные я наконец решил съездить в Санкт-Петербург. Я давно хотел это сделать, но всё откладывал. А ведь добраться туда совсем несложно — поездка на «Сапсане» занимает всего около четырёх часов. Расстояние между Москвой и Петербургом — примерно семьсот километров. Раньше, когда я был школьником, мы ездили туда на поезде всей ночью, и это казалось настоящим путешествием.\r\n\r\nВ среду вечером я купил билеты на сайте РЖД — туда и обратно за шесть с половиной тысяч рублей. Поездка была запланирована на пятницу. Я заранее договорился с начальником, чтобы уйти с работы немного раньше. Приехал на Ленинградский вокзал за полчаса до отправления и спокойно сел в поезд.\r\n\r\nСанкт-Петербург встретил меня прохладной, но солнечной погодой. Я провёл два дня в этом прекрасном городе. Успел погулять по Невскому проспекту, сходить в Эрмитаж, посмотреть на развод мостов ночью и даже покататься на теплоходе по каналам. Атмосфера города, его архитектура и уютные кофейни сделали мой уикенд особенным.\r\n\r\nВ воскресенье вечером я вернулся домой немного уставшим, но очень довольным. Теперь точно знаю — такие поездки нужно устраивать почаще.",
                    Language = "Russian",
                    Level = "B1",
                    Slug = "nezabyvaemye-vyhodnye-v-sankt-peterburge"
                },

                new Text
                {
                    Id = 45,
                    TextTitle= "Первый рабочий день в новой компании",
                    LanguageText = "После нескольких месяцев поиска работы и отправки резюме я наконец получил приглашение на должность в IT-компанию, занимающуюся разработкой мобильных приложений. Я давно интересовался этой сферой, поэтому был невероятно рад, когда мне сообщили, что я принят.\r\n\r\nВ первый день я проснулся пораньше, чтобы не опоздать. Я выбрал спокойный, но аккуратный наряд, так как в IT-среде нет строгого дресс-кода. Офис находился в современном здании в центре города. Просторные светлые помещения, удобные рабочие зоны и дружелюбная атмосфера сразу произвели на меня хорошее впечатление.\r\n\r\nМеня встретила менеджер по персоналу и провела краткую экскурсию по офису. Затем я познакомился с моей командой – это были молодые специалисты, увлечённые своим делом. Моим наставником стал старший разработчик по имени Андрей. Он сразу предложил помощь и объяснил, чем я буду заниматься в ближайшее время.\r\n\r\nВ первый день мне дали несколько несложных заданий, чтобы я смог освоиться с внутренними инструментами и подходом к работе. Я также поучаствовал во встрече команды, где обсуждались текущие проекты. Всё происходило в неформальной и уважительной обстановке, что очень меня порадовало.\r\n\r\nПосле работы коллеги пригласили меня поужинать в кафе недалеко от офиса. Это была отличная возможность лучше узнать друг друга и почувствовать себя частью коллектива. Я ушёл домой с ощущением, что сделал правильный выбор и впереди меня ждёт интересная профессиональная жизнь.",
                    Language = "Russian",
                    Level = "B2",
                    Slug = "pervyy-rabochiy-den-v-novoy-kompanii"
                },

                new Text
                {
                    Id = 46,
                    TextTitle = "Письмо другу",
                    LanguageText = "Привет, Алексей!\r\n\r\nЯ был очень рад получить твоё письмо. Здорово, что у тебя всё хорошо и что ты наконец-то завершил ремонт в квартире. Представляю, сколько это заняло времени и сил. Надеюсь, теперь вы с Олей сможете немного отдохнуть и подумать о путешествии.\r\n\r\nЕсли вы всё же решите приехать летом в Казань, мы с удовольствием примем вас у себя. У нас просторная квартира, и для вас найдётся отдельная комната. Мы уже продумываем, куда можно будет сходить вместе. Первым делом, конечно, стоит посетить Казанский Кремль. Это не только исторический центр города, но и место с потрясающими видами на Волгу.\r\n\r\nОбязательно покажем вам улицу Баумана – это наша пешеходная зона, полная кафе, сувенирных лавок и уличных артистов. Также можно съездить на озеро Кабан, покататься на катамаране или просто прогуляться по набережной. Если захотите узнать больше о местной культуре, заглянем в Национальный музей Татарстана.\r\n\r\nНу а если вы приедете в июле, попадёте на фестиваль татарской культуры «Сабантуй» – будет весело и вкусно. Поверь, ты точно не останешься равнодушным к нашей кухне: эчпочмаки, чак-чак, кыстыбый – всё это стоит попробовать.\r\n\r\nЖду от тебя весточки. Напиши, как только определитесь с планами.\r\n\r\nТвой друг,\r\nМихаил",
                    Language = "Russian",
                    Level = "B2",
                    Slug = "pismo-drugu"
                },

                new Text
                {
                    Id = 47,
                    TextTitle = "Планы на будущее",
                    LanguageText = "Прошлый год стал для меня важным этапом: я закончил магистратуру и получил диплом. Теперь я готов строить свою профессиональную карьеру. Мне удалось устроиться в международную компанию на должность младшего аналитика. Работа интересная, но требует постоянного развития, поэтому в ближайшие месяцы я собираюсь пройти курсы повышения квалификации.\r\n\r\nОдной из главных целей на ближайшее будущее является переезд в собственное жильё. Сейчас я живу на съёмной квартире, но уже начал откладывать деньги на первый взнос по ипотеке. Планирую купить однокомнатную квартиру в новом районе с хорошей инфраструктурой. Надеюсь, что за год смогу накопить нужную сумму.\r\n\r\nКроме того, хочу больше путешествовать. Пока что был только в паре стран Европы, но мечтаю увидеть Азию – особенно Японию и Южную Корею. Планирую взять отпуск в следующем году и отправиться туда хотя бы на две недели.\r\n\r\nЯ понимаю, что все эти цели требуют времени, дисциплины и финансов, но я настроен решительно. Уверен, что при достаточной настойчивости смогу всё реализовать.",
                    Language = "Russian",
                    Level = "B2",
                    Slug = "plany-na-budushchee"
                },

                new Text
                {
                    Id = 48,
                    TextTitle = "Жизнь в большом городе",
                    LanguageText = "Жить в мегаполисе – это, безусловно, интересный и насыщенный опыт. Большой город предоставляет множество возможностей: здесь легче найти работу, получить качественное образование, познакомиться с новыми людьми и попробовать себя в разных сферах жизни.\r\n\r\nС одной стороны, в мегаполисе всё находится рядом – магазины, культурные мероприятия, спортзалы, кафе, театры. Благодаря развитой инфраструктуре можно быстро добраться из одной части города в другую. Особенно это удобно для тех, кто ценит время и активный образ жизни.\r\n\r\nОднако у жизни в большом городе есть и свои минусы. Пробки на дорогах, высокий уровень шума и загрязнённый воздух могут негативно влиять на здоровье и настроение. Кроме того, из-за большого количества людей не всегда легко почувствовать себя в безопасности и расслабиться. Часто у горожан возникает чувство усталости и хронического стресса.\r\n\r\nНесмотря на трудности, многие не представляют свою жизнь вне большого города. Он даёт ощущение движения вперёд, вдохновляет развиваться и не останавливаться на достигнутом. Главное – уметь находить баланс между работой и отдыхом, чтобы жизнь в мегаполисе приносила радость, а не только усталость.",
                    Language = "Russian",
                    Level = "B2",
                    Slug = "zhizn-v-bolshom-gorode"
                }
                

               




                
                
                );

            modelBuilder.Entity<Question>().HasData(

                //Questions for the Text: Mitt husdjur
                new Question
                {
                    Id = 1,
                    TextId = 1,
                    Content = "Hur gammal är Emma?",
                    option1 = "Tio år",
                    option2 = "Tretton år",
                    option3 = "Fjorton år",
                    option4 = "Tolv år",
                    CorrectOption = 2
                },

                new Question
                {
                    Id = 2,
                    TextId = 1,
                    Content = "Vad heter Emmas hund?",
                    option1 = "Leo",
                    option2 = "Max",
                    option3 = "Lukas",
                    option4 = "Rex",
                    CorrectOption = 2
                },

                new Question
                {
                    Id = 3,
                    TextId = 1,
                    Content = " Vad kan Max göra enligt texten?",
                    option1 = "Prata och hoppa",
                    option2 = "Rulla runt och skälla",
                    option3 = "Sitta, ligga och ge tass",
                    option4 = "Simma och dansa",
                    CorrectOption = 3
                },

                new Question
                {
                    Id = 4,
                    TextId = 1,
                    Content = "Vad gör familjen ibland på helgerna?",
                    option1 = "Går på bio",
                    option2 = "Åker till landet",
                    option3 = "Besöker farföräldrarna",
                    option4 = "Tittar på TV hela dagen",
                    CorrectOption = 2
                },

                //Questions for the Text: En dag i parken
                new Question
                {
                    Id = 5,
                    TextId = 2,
                    Content = "Vad gör den lilla pojken och hans pappa i parken?",
                    option1 = "De spelar fotboll",
                    option2 = "De matar fåglar",
                    option3 = "De köper glass och sitter i gräset",
                    option4 = "De läser böcker på en bänk",
                    CorrectOption = 3
                },

                new Question
                {
                    Id = 6,
                    TextId = 2,
                    Content = "Vilken smak på glassen väljer pojken?",
                    option1 = "Vanilj",
                    option2 = "Choklad",
                    option3 = "Jordgubb",
                    option4 = "Citron",
                    CorrectOption = 3
                },

                new Question
                {
                    Id = 7,
                    TextId = 2,
                    Content = "Vad händer när flickan gör mål i fotbollsmatchen?",
                    option1 = "Hunden skäller",
                    option2 = "Alla klappar händerna",
                    option3 = "Pojken gråter",
                    option4 = "Någon ramlar",
                    CorrectOption = 2
                },

                new Question
                {
                    Id = 8,
                    TextId = 2,
                    Content = "Vad gör den gamla mannen vid fontänen?",
                    option1 = "Han matar duvor",
                    option2 = "Han sover på en bänk",
                    option3 = "Han läser en bok",
                    option4 = "Han spelar gitarr",
                    CorrectOption = 1
                },

                //Questions for the Text: Lucas berättar om sin skola 
                new Question
                {
                    Id = 9,
                    TextId = 3,
                    Content = "Vad heter skolan där Lucas går?",
                    option1 = "Solgården",
                    option2 = "Solskolan",
                    option3 = "Skolgården",
                    option4 = "Solbacken",
                    CorrectOption = 2

                },

                new Question
                {
                    Id = 10,
                    TextId = 3,
                    Content = "Hur tar sig Lucas till skolan?",
                    option1 = "Han går dit",
                    option2 = "Han åker buss",
                    option3 = "Han cyklar",
                    option4 = "Han åker bil med sin mamma",
                    CorrectOption = 3
                },

                new Question
                {
                    Id = 11,
                    TextId = 3,
                    Content = "Var ligger Lucas klassrum?",
                    option1 = "På första våningen",
                    option2 = "Bredvid matsalen",
                    option3 = "I källaren",
                    option4 = "På andra våningen",
                    CorrectOption = 4
                },

                new Question
                {
                    Id = 12,
                    TextId = 3,
                    Content = "Vad är Lucas favoritplats i klassrummet?",
                    option1 = "Vid whiteboarden",
                    option2 = "Nära bokhyllan",
                    option3 = "Vid fönstret",
                    option4 = "Bredvid dörren",
                    CorrectOption = 3
                },

                //Questions for the Text: Min vän Anna

                new Question
                {
                    Id = 13,
                    TextId = 4,
                    Content = "Hur länge har Elin och Anna varit vänner?",
                    option1 = "Ett år",
                    option2 = "Två år",
                    option3 = "Tre år",
                    option4 = "Fem år",
                    CorrectOption = 3
                },

                new Question
                {
                    Id = 14,
                    TextId = 4,
                    Content = "Vad hänger på väggen i Elins rum?",
                    option1 = "En spegel",
                    option2 = "Ett porträtt som Anna har ritat",
                    option3 = "En karta över världen",
                    option4 = " En affisch med musikband",
                    CorrectOption = 2
                },

                new Question
                {
                    Id = 15,
                    TextId = 4,
                    Content = "Vad gör Elin och Anna ofta på helgerna?",
                    option1 = "Går på bio",
                    option2 = "Springer i parken",
                    option3 = "Bakar muffins eller chokladkaka",
                    option4 = "Tittar på serier",
                    CorrectOption = 3
                },

                new Question
                {
                    Id = 16,
                    TextId = 4,
                    Content = "Vilken typ av böcker tycker Anna om?",
                    option1 = "Kärleksromaner",
                    option2 = "Fakta-och historieböcker",
                    option3 = "Äventyr och mysterier",
                    option4 = "Diktsamlingar",
                    CorrectOption = 3
                },


                 //Questions for the Text: Erik glömmer sitt paraply

                new Question
                {
                    Id = 17,
                    TextId = 5,
                    Content = "När inser Erik att han har glömt sitt paraply?",
                    option1 = "När han dricker sitt kaffe",
                    option2 = "När han går ut genom dörren",
                    option3 = "När han ser andra med paraply",
                    option4 = "När det börjar regna vid busshållplatsen ",
                    CorrectOption = 4  
                },

                new Question
                {
                    Id = 18,
                    TextId = 5,
                    Content = "Vad händer när Erik väntar på bussen?",
                    option1 = "Han träffar en vän",
                    option2 = "Det börjar regna kraftigt",
                    option3 = "Bussen kommer i tid",
                    option4 = "Han hittar ett paraply",
                    CorrectOption = 2 
                },

                new Question
                {
                    Id = 19,
                    TextId = 5,
                    Content = "Hur känner sig Erik när han sitter på bussen?",
                    option1 = "Han pratar med folk",
                    option2 = "Han är glad och sjunger",
                    option3 = "Han sitter tyst och tittar ut genom fönstret ",
                    option4 = "Han sover",
                    CorrectOption = 3
                },

                new Question
                {
                    Id = 20,
                    TextId = 5,
                    Content = "Vad säger Eriks kollega när han kommer till jobbet?",
                    option1 = "Du ser väldigt trött ut!",
                    option2 = "Vill du ha en kopp kaffe?",
                    option3 = "Du borde nog kolla vädret innan du går hemifrån!",
                    option4 = "Varför tog du med paraply?",
                    CorrectOption = 3 
                },

                //Questions for the Text: Min familj och våra traditioner

                new Question
                {
                    Id =21,
                    TextId = 6,
                    Content = "Vad jobbar huvudpersonens storasyster med?",
                    option1 = "Lärare",
                    option2 = "Sjuksköterska",
                    option3 = "Elektriker",
                    option4 = "Kafébiträde",
                    CorrectOption = 2
                },

                new Question
                {
                    Id = 22,
                    TextId = 6,
                    Content = "Vad brukar familjen göra på söndagar?",
                    option1 = "Gå på bio tillsammans",
                    option2 = "Städa hela huset",
                    option3 = "Äta middag och spela sällskapsspel",
                    option4 = "Titta på sport",
                    CorrectOption = 3
                },

                new Question
                {
                    Id =  23,
                    TextId = 6,
                    Content = "Vad tycker pappan om att göra?",
                    option1 = "Spela gitarr",
                    option2 = "Läsa böcker",
                    option3 = "Träna på gym",
                    option4 = "Fixa saker i huset",
                    CorrectOption = 4
                },

                new Question
                {
                    Id = 24,
                    TextId = 6,
                    Content = "Vad heter familjens katt och vad gillar den att göra?",
                    option1 = "Maja – ligga i solen på balkongen",
                    option2 = "Molly – jaga möss i trädgården",
                    option3 = "Max – sova under soffan",
                    option4 = "Mimmi – leka med barnen",
                    CorrectOption = 1
                },


                //Questions for the Text: Linas söndag

                new Question
                {
                    Id = 25,
                    TextId = 7,
                    Content = "Vad gör Lina först på söndagsmorgonen efter att hon har vaknat?",
                    option1 = "Går ut på promenad",
                    option2 = "Tar en lång dusch",
                    option3 = "Ställer väckarklockan",
                    option4 = "Städar lägenheten",
                    CorrectOption = 2
                },

                new Question
                {
                    Id = 26,
                    TextId = 7,
                    Content = "Vad brukar Lina göra vid elva på förmiddagen?",
                    option1 = "Äta lunch",
                    option2 = "Träffa sina föräldrar",
                    option3 = "Gå på promenad i parken ",
                    option4 = "Laga middag",
                    CorrectOption = 3
                },

                new Question
                {
                    Id = 27,
                    TextId = 7,
                    Content = "Vad gör Lina efter promenaden?",
                    option1 = "Tittar på film",
                    option2 = "Handlar mat och planerar middagar",
                    option3 = "Tränar på gymmet",
                    option4 = "Besöker en vän",
                    CorrectOption = 2
                },

                new Question
                {
                    Id = 28,
                    TextId = 7,
                    Content = "Vad gör Lina på kvällen?",
                    option1 = "Går till biblioteket",
                    option2 = "Städar hela lägenheten",
                    option3 = "Lagar mat och ser en film eller läser en bok",
                    option4 = "Går ut med vänner",
                    CorrectOption = 3
                },

                //Questions for the Text: Mitt rum i lägenheten

                new Question
                {
                    Id = 29,
                    TextId = 8,
                    Content = "Vad finns i personens rum enligt texten?",
                    option1 = "En dubbelsäng och en TV",
                    option2 = "En enkelsäng, skrivbord, stol och bokhylla",
                    option3 = "Ett kök och ett matbord",
                    option4 = " En våningssäng och ett piano",
                    CorrectOption = 2
                },

                new Question
                {
                    Id = 30,
                    TextId = 8,
                    Content = "Vad står under fönstret i rummet?",
                    option1 = "Ett skrivbord",
                    option2 = "En bokhylla",
                    option3 = "En liten soffa",
                    option4 = " En garderob",
                    CorrectOption =  3
                },

                new Question
                {
                    Id = 31,
                    TextId = 8,
                    Content = "Vilken växt är personens favorit?",
                    option1 = "En ros",
                    option2 = "En orkidé",
                    option3 = "En solros",
                    option4 = "En liten kaktus",
                    CorrectOption = 4
                },

                new Question
                {
                    Id = 32,
                    TextId = 8,
                    Content = "Vad tycker personen bäst om med sitt rum?",
                    option1 = "Att det är stort och fullt av teknik",
                    option2 = "De gröna väggarna och att det är tyst",
                    option3 = "Att det finns mycket mat",
                    option4 = "Att det ligger nära universitetet",
                    CorrectOption = 2
                },

                //Questions for the Text: Erik skriver ett personligt brev

                new Question
                {
                    Id = 33,
                    TextId = 9,
                    Content = "Var bor Erik och med vem?",
                    option1 = "I Stockholm med sina föräldrar",
                    option2 = "I Malmö ensam",
                    option3 = "I Göteborg med sin sambo",
                    option4 = "I Uppsala med sin syster",
                    CorrectOption = 3
                },

                new Question
                {
                    Id = 34,
                    TextId = 9,
                    Content = "Vilket jobb söker Erik?",
                    option1 = "Säljare",
                    option2 = "Kundserviceassistent",
                    option3 = "Lärare",
                    option4 = "Systemutvecklare",
                    CorrectOption = 2
                },

                new Question
                {
                    Id = 35,
                    TextId = 9,
                    Content = "Vad är några av Eriks styrkor enligt brevet?",
                    option1 = "Kreativ, spontan och sportig",
                    option2 = "Ansvarsfull, noggrann och tystlåten",
                    option3 = "Tålamodig, ansvarsfull och noggrann",
                    option4 = "Självsäker, envis och flexibel",
                    CorrectOption = 3
                },

                new Question
                {
                    Id = 36,
                    TextId = 9,
                    Content = "Vad lärde sig Erik på sitt tidigare jobb på callcenter?",
                    option1 = "Att använda Excel och PowerPoint",
                    option2 = "Att jobba hemifrån",
                    option3 = "Att hantera stress och vara vänlig i svåra situationer",
                    option4 = "Att sälja produkter via e-post",
                    CorrectOption = 3
                },

                //Questions for the Text: Min garderob

                new Question
                {
                    Id = 37,
                    TextId = 10,
                    Content = "Vilken typ av tröja tycker personen mest om att använda?",
                    option1 = "T-shirts",
                    option2 = "Skjortor",
                    option3 = "Hoodies ",
                    option4 = " Stickade tröjor",
                    CorrectOption = 3
                },

                new Question
                {
                    Id = 38,
                    TextId = 10,
                    Content = "Hur ser personens favorithoodie ut?",
                    option1 = "Den är grå med dragkedja",
                    option2 = "Den är mörkblå och har en stor ficka fram",
                    option3 = "Den är röd med mönster",
                    option4 = "Den är vit och tunn",
                    CorrectOption = 2
                },

                new Question
                {
                    Id  = 39,
                    TextId = 10,
                    Content = "Vad använder personen nästan varje dag?",
                    option1 = "Ett par svarta jeans",
                    option2 = "En mönstrad skjorta",
                    option3 = "En vinterjacka",
                    option4 = "Ett par blå shorts",
                    CorrectOption =  1
                },

                new Question
                {
                    Id = 40,
                    TextId = 10,
                    Content = "Var förvaras mössor, vantar och halsdukar?",
                    option1 = "I en låda under sängen",
                    option2 = "På en krok bakom dörren",
                    option3 = "I byrålådan",
                    option4 = "På en hylla högst upp i garderoben",
                    CorrectOption = 4
                },

                //Questions for the Text: Göteborg

                new Question
                {
                    Id = 41,
                    TextId = 11,
                    Content = "Hur länge stannade de i Göteborg?",
                    option1 = "Två dagar",
                    option2 = "Fyra dagar",
                    option3 = "Tre dagar",
                    option4 = "En vecka",
                    CorrectOption = 3

                },

                new Question
                {
                    Id = 42,
                    TextId = 11,
                    Content = "Vad gillade de mest med Göteborg enligt texten?",
                    option1 = "Skyskraporna och nattlivet",
                    option2 = "Parkerna och närheten till havet",
                    option3 = "Shoppinggalleriorna",
                    option4 = "Historiska museer",
                    CorrectOption = 2
                },

                new Question
                {
                    Id = 43,
                    TextId = 11,
                    Content = "Vad gjorde de i Slottsskogen?",
                    option1 = "De tältade över natten",
                    option2 = "De promenerade bland djur och grönområden",
                    option3 = "De åt på ett kafé",
                    option4 = "De spelade fotboll med lokalbefolkningen",
                    CorrectOption = 2
                },

                new Question
                {
                    Id = 44,
                    TextId = 11,
                    Content = "Vad gjorde de i Liseberg?",
                    option1 = "De åkte karuseller, spelade på lyckohjul och åt sockervadd",
                    option2 = "De gick på museum",
                    option3 = "De såg en teaterföreställning",
                    option4 = "De badade i en bassäng",
                    CorrectOption = 1 
                },

                //Questions for the Text:  Sara och Erik bokar en resa

                new Question
                {
                    Id = 45,
                    TextId = 12,
                    Content = "Vart vill Sara och Erik resa i sommar?",
                    option1 = "Spanien",
                    option2 = "Grekland",
                    option3 = "Italien ",
                    option4 = "Frankrike",
                    CorrectOption = 3
                },

                new Question
                {
                    Id = 46,
                    TextId = 12,
                    Content = "Hur länge vill de stanna i Rom?",
                    option1 = "Två veckor",
                    option2 = "Tio dagar",
                    option3 = "En helg",
                    option4 = "En vecka",
                    CorrectOption = 4
                },

                new Question
                {
                    Id = 47,
                    TextId = 12,
                    Content = "Vad ingår i deras bokningspaket?",
                    option1 = "Endast flyg",
                    option2 = "Flyg, hotell och frukost ",
                    option3 = "Flyg och hyrbil",
                    option4 = "Hotell och middag",
                    CorrectOption = 2
                },

                new Question
                {
                    Id = 48,
                    TextId = 12,
                    Content = "Varför vill de inte hyra bil?",
                    option1 = "De har inte körkort",
                    option2 = "De vill spara pengar",
                    option3 = "De tänker promenera och åka tunnelbana",
                    option4 = "Det finns inga bilar lediga",
                    CorrectOption = 3
                },

                //Question for the text: Familjen Eriksson på botaniska trädgården

                new Question
                {
                    Id = 49,
                    TextId = 13,
                    Content = "Vad tycker Sofia mest om i den botaniska trädgården?",
                    option1 = "Körsbärsträd",
                    option2 = "Kaktusar",
                    option3 = "Orkidéer",
                    option4 = "Gamla ekar",
                    CorrectOption = 3
                },

                new Question
                {
                    Id = 50,
                    TextId = 13,
                    Content = "Varför fotograferar Johan träd?",
                    option1 = "För att skicka bilder till en tävling",
                    option2 = "För sitt fotoprojekt i skolan",
                    option3 = "För att visa sin farmor",
                    option4 = "För att sälja dem online",
                    CorrectOption = 2
                },

                new Question
                {
                    Id = 51,
                    TextId = 13,
                    Content = "Vad gillar mamma Maria mest med den japanska delen av trädgården?",
                    option1 = "Växthusen",
                    option2 = "De gamla trädens rötter",
                    option3 = "Fåglarna i träden",
                    option4 = "Dammar, stenbroar och körsbärsträd",
                    CorrectOption = 4
                },

                new Question
                {
                    Id = 52,
                    TextId = 13,
                    Content = "Vad gör familjen alltid efter promenaden i trädgården?",
                    option1 = "Går hem direkt",
                    option2 = "Sätter sig vid caféet och fikar",
                    option3 = "Besöker ett museum",
                    option4 = "Tar en guidad tur",
                    CorrectOption = 2
                },

                //Questions for the Text: Kladdkakans dag i Sverige

                new Question
                {
                    Id = 54,
                    TextId = 14,
                    Content = "När firas Kladdkakans dag i Sverige?",
                    option1 = "4 oktober",
                    option2 = "25 december",
                    option3 = "7 november",
                    option4 = "1 maj",
                    CorrectOption = 3
                },

                new Question
                {
                    Id = 55,
                    TextId = 14,
                    Content = "Vad är kladdkaka?",
                    option1 = "En söt, kladdig chokladkaka",
                    option2 = "En mjuk kaka med sylt",
                    option3 = "En frasig smördegskaka",
                    option4 = "En sockerkaka med vanilj",
                    CorrectOption = 1
                },

                new Question
                {
                    Id = 56,
                    TextId = 14,
                    Content = "Vilken ingrediens används INTE i kladdkakan enligt receptet?",
                    option1 = "Kakao",
                    option2 = "Smör",
                    option3 = "Mjölk",
                    option4 = "Vetemjöl",
                    CorrectOption = 3
                },

                new Question
                {
                    Id = 57,
                    TextId = 14,
                    Content = "Vad händer om du gräddar kladdkakan kortare tid?",
                    option1 = "Den blir torrare",
                    option2 = "Den blir kladdigare",
                    option3 = "Den smakar mindre",
                    option4 = "Den blir hårdare",
                    CorrectOption = 2
                },

                //Questions for the Text:Spelens värld – mer än bara underhållning

                new Question
                {
                    Id = 58,
                    TextId = 15,
                    Content = "Vilka färdigheter kan man utveckla genom att spela multiplayer-spel?",
                    option1 = "Bara reflexer och snabbhet",
                    option2 = "Kommunikation, lagarbete och strategiskt tänkande",
                    option3 = "Matlagning och hantverk",
                    option4 = " Läsa och skriva poesi",
                    CorrectOption = 2
                },

                new Question
                {
                    Id = 59,
                    TextId = 15,
                    Content = "Vad är e-sport enligt texten?",
                    option1 = "Ett enkelt spel för barn",
                    option2 = "Ett sätt att spela ensam",
                    option3 = "En global företeelse där professionella tävlar och många tittar online",
                    option4 = " Ett träningsprogram för gym",
                    CorrectOption = 3
                },

                new Question
                {
                    Id = 60,
                    TextId = 15,
                    Content = "Vilken kritik nämns i texten om spel?",
                    option1 = "Spel kan leda till beroende och påverka livet negativt ",
                    option2 = "De förstör grafikkort",
                    option3 = "Spel är för dyra",
                    option4 = "De är för svåra att förstå",
                    CorrectOption = 1
                },

                new Question
                {
                    Id = 61,
                    TextId = 15,
                    Content = "Vad säger texten om framtiden för spelindustrin?",
                    option1 = "Den kommer troligen att minska",
                    option2 = "Den är osäker på grund av bristande intresse",
                    option3 = "Den ser spännande ut med ny teknik som VR och AI ",
                    option4 = "Den kommer att försvinna helt",
                    CorrectOption = 3
                },

                //Questions for the Text: Svensk natur är som en sagovärld

                new Question
                {
                    Id = 62,
                    TextId = 16,
                    Content = "Hur gammal är Elin som berättar i texten?",
                    option1 = "Sex år",
                    option2 = "Sju år",
                    option3 = "Åtta år",
                    option4 = "Nio år",
                    CorrectOption = 3
                },

                new Question
                {
                    Id = 63,
                    TextId = 16,
                    Content = "Vad ser Elin när hon går i skogen?",
                    option1 = "En ekorre som hoppar från gren till gren ",
                    option2 = "Hjortar och rävar",
                    option3 = "En björn och en uggla",
                    option4 = "En bäver som bygger ett bo",
                    CorrectOption = 1
                },

                new Question
                {
                    Id = 64,
                    TextId = 16,
                    Content = "Vad gör Elin vid sjön?",
                    option1 = "Hon badar i vattnet",
                    option2 = "Hon fiskar med sin pappa",
                    option3 = "Hon bygger ett sandslott",
                    option4 = "Hon plockar en blå blomma och sätter den i håret",
                    CorrectOption = 4
                },

                new Question
                {
                    Id = 65,
                    TextId = 16,
                    Content = "Vad säger Elins mamma om naturen?",
                    option1 = "Att man inte får plocka blommor",
                    option2 = "Att naturen är tråkig på vintern",
                    option3 = "Att vi måste ta hand om den för att den är en skatt",
                    option4 = "Att man alltid måste ta med sig ett tält",
                    CorrectOption = 3
                }

                );
        }
    }
}
