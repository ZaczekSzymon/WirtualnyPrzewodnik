using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MapsApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Informacje : ContentPage
    {
        
        private Button openBazylika;
        private Button openWikiBazylika;

        private Button openZamek;
        private Button openWikiZamek;

        private Button openPlanty;
        private Button openWikiPlanty;

        private Button openRatusz;
        private Button openWikiRatusz;

        private Button openCmentarz;
        private Button openWikiCmentarz;

        private Button openZegar;
        private Button openWikiZegar;

        private Button openPKP;
        private Button openwikiPKP;

        private Button openRezydencja;
        private Button openwikiRezydencja;

        private Button openSynagoga;
        private Button openwikiSynagoga;

        private Button openDGotycki;
        private Button openwikiDGotycki;

        private Button openKapliczka;
        private Button openwikiKapliczka;

        private Button openSokol;
        private Button openwikiSokol;

        private Button back;
        private Button back_2;
        private Button back_3;
        private Button back_4;
        private Button back_5;
        private Button back_6;

        private Button back_7;
        private Button back_8;
        private Button back_9;
        private Button back_10;
        private Button back_11;
        private Button back_12;

        private StackLayout stackLayout;

        private StackLayout stackLayoutBazylika;
        private StackLayout stackLayoutZamek;
        private StackLayout stackLayoutPlanty;
        private StackLayout stackLayoutRatusz;
        private StackLayout stackLayoutCmentarz;
        private StackLayout stackLayoutZegar;

        private StackLayout stackLayoutDworzec;
        private StackLayout stackLayoutRezydencja;
        private StackLayout stackLayoutSynagoga;
        private StackLayout stackLayoutDGotycki;
        private StackLayout stackLayoutKapliczka;
        private StackLayout stackLayoutSokol;

        

        public Informacje()
        {
            Title = "Informacje";

            back = new Button
            {
                Text = "Wróć"
            };

            back_2 = new Button
            {
                Text = "Wróć"
            };

            back_3 = new Button
            {
                Text = "Wróć"
            };

            back_4 = new Button
            {
                Text = "Wróć"
            };

            back_5= new Button
            {
                Text = "Wróć"
            };

            back_6 = new Button
            {
                Text = "Wróć"
            };

            back_7 = new Button
            {
                Text = "Wróć"
            };

            back_8 = new Button
            {
                Text = "Wróć"
            };

            back_9 = new Button
            {
                Text = "Wróć"
            };

            back_10 = new Button
            {
                Text = "Wróć"
            };

            back_11 = new Button
            {
                Text = "Wróć"
            };

            back_12 = new Button
            {
                Text = "Wróć"
            };

            openZegar = new Button
            {
                Text = "Zegar kwiatowy"
            };



            openWikiZegar = new Button
            {
                Text = "Wiecej informacji"
            };

            openCmentarz = new Button
            {
                Text = "Cmentarz komunalny"
            };


            openWikiCmentarz = new Button
            {
                Text = "Wiecej informacji"
            };

            openPlanty = new Button
            {
                Text = "Planty"
            };


            openWikiRatusz = new Button
            {
                Text = "Wiecej informacji"
            };

            openRatusz = new Button
            {
                Text = "Ratusz"
            };


            openWikiPlanty = new Button
            {
                Text = "Wiecej informacji"
            };

            openBazylika = new Button
            {
                Text = "Bazylika kolegiacka"
            };


            openWikiBazylika = new Button
            {
                Text = "Wiecej informacji"
            };

            openZamek = new Button
            {
                Text = "Ruiny Zamku królewskiego"
            };


            openWikiZamek = new Button
            {
                Text = "Wiecej informacji"
            };

            openPKP = new Button
            {
                Text = "Dworzec PKP"
            };
            openRezydencja = new Button
            {
                Text = "Rezydencja Lubomirskich"
            };

            openSynagoga = new Button
            {
                Text = "Dawna Synagoga"
            };

            openDGotycki = new Button
            {
                Text = "Dom Gotycki"
            };

            openKapliczka = new Button
            {
                Text = "Kapliczka Szwedzka"
            };

            openSokol = new Button
            {
                Text = "Sokół"
            };




            openwikiPKP = new Button
            {
                Text = "Wiecej informacji"
            };
            openwikiRezydencja = new Button
            {
                Text = "Wiecej informacji"
            };

            openwikiSynagoga = new Button
            {
                Text = "Wiecej informacji"
            };

            openwikiDGotycki = new Button
            {
                Text = "Wiecej informacji"
            };

            openwikiKapliczka = new Button
            {
                Text = "Wiecej informacji"
            };

            openwikiSokol = new Button
            {
                Text = "Wiecej informacji"
            };

            openBazylika.Clicked += OpenBazylika_Clicked;
            openZamek.Clicked += OpenZamek_Clicked;
            openPlanty.Clicked += OpenPlanty_Clicked1;
            openRatusz.Clicked += OpenRatusz_Clicked;
            openCmentarz.Clicked += OpenCmentarz_Clicked;
            openZegar.Clicked += OpenZegar_Clicked;
            openPKP.Clicked += OpenPKP_Clicked;
            openRezydencja.Clicked += OpenRezydencja_Clicked;
            openSynagoga.Clicked += OpenSynagoga_Clicked;
            openDGotycki.Clicked += OpenDGotycki_Clicked;
            openKapliczka.Clicked += OpenKapliczka_Clicked;
            openSokol.Clicked += OpenSokol_Clicked;
            

            openWikiBazylika.Clicked += OpenWikiBazylika_Clicked;
            openWikiZamek.Clicked += OpenWikiZamek_Clicked;
            openWikiPlanty.Clicked += OpenWikiPlanty_Clicked1;
            openWikiRatusz.Clicked += OpenWikiRatusz_Clicked;
            openWikiZegar.Clicked += OpenWikiZegar_Clicked;
            openWikiCmentarz.Clicked += OpenWikiCmentarz_Clicked;

            openwikiPKP.Clicked += OpenwikiPKP_Clicked;
            openwikiRezydencja.Clicked += OpenwikiRezydencja_Clicked;
            openwikiSynagoga.Clicked += OpenwikiSynagoga_Clicked;
            openwikiDGotycki.Clicked += OpenwikiDGotycki_Clicked;
            openwikiKapliczka.Clicked += OpenwikiKapliczka_Clicked;
            openwikiSokol.Clicked += OpenwikiSokol_Clicked;


            back.Clicked += Back_Clicked;
            back_2.Clicked += Back_2_Clicked;
            back_3.Clicked += Back_3_Clicked;
            back_4.Clicked += Back_4_Clicked;
            back_5.Clicked += Back_5_Clicked;
            back_6.Clicked += Back_6_Clicked;

            back_7.Clicked += Back_7_Clicked;
            back_8.Clicked += Back_8_Clicked;
            back_9.Clicked += Back_9_Clicked;
            back_10.Clicked += Back_10_Clicked;
            back_11.Clicked += Back_11_Clicked;
            back_12.Clicked += Back_12_Clicked;
           


            stackLayout = new StackLayout
            {
                
                Orientation = StackOrientation.Vertical,
                Spacing = 10,
                Padding = new Thickness(10),
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions= LayoutOptions.FillAndExpand,
                Children =
                {
                     new Label
                    {Text="CIEKAWOSTKI",
                    HorizontalOptions= LayoutOptions.Center,
                    TextColor = Color.Maroon,
                    FontSize = 18,
                    FontAttributes = FontAttributes.Bold,

                    },
                    openBazylika,
                    openZamek,
                    openPlanty,
                    openRatusz,
                    openCmentarz,
                    openZegar,
                    openPKP,
                    openRezydencja,
                    openSynagoga,
                    openDGotycki,
                    openKapliczka,
                    openSokol
                   
                }
            };

            

            stackLayoutBazylika = new StackLayout
            {

               
            Orientation = StackOrientation.Vertical,
                Spacing = 10,
                Padding = new Thickness(10),
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Children =
                {
                     new Label
                    {Text="Bazylika Kolegiacka",
                    HorizontalOptions= LayoutOptions.Center,
                    TextColor = Color.Maroon,
                    FontSize = 24,
                    FontAttributes = FontAttributes.Bold,
                    },

                    new Image { Source = "https://static.polskieszlaki.pl/zdjecia/wycieczki/2015-09/nowy-sacz-21.jpg"},

                    new Label
                    {Text="Kościół pochodzi z przełomu XIII / XIV wieku. W roku 1448 podniesiony przez biskupa krakowskiego Zbigniewa Oleśnickiego do rangi kolegiaty. W trakcie XV-wiecznych przebudów powstały m.in. dwie wieże: północna (1460 r.) i południowa (ukończona w 1507 r., z fundacji biskupa krakowskiego Jana Konarskiego). Ta druga, ze względu na błędy konstrukcyjne grożąca zawaleniem, została rozebrana około 1580 r. i ponownie odbudowana w stylu pełnego renesansu. Ponieważ pełniła ona funkcję dzwonnicy, zawieszono na niej cztery dzwony: potężny „Michał Archanioł” (największy w Małopolsce po „Zygmuncie”) i mniejsze – „św. Jan”, „św. Małgorzata” i „św. Marcin”.",
                    HorizontalOptions= LayoutOptions.CenterAndExpand,
                    TextColor = Color.Black,
                    FontSize = 16,
                    FontAttributes = FontAttributes.None,
                    HorizontalTextAlignment = TextAlignment.Start

                    },

                    openWikiBazylika,
                    back,


                }
            };

            stackLayoutZamek = new StackLayout
            {

                Orientation = StackOrientation.Vertical,
                Spacing = 10,
                Padding = new Thickness(10),
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
              
                Children =
                {
                      new Label
                    {Text="Ruiny zamku królewskiego",
                    HorizontalOptions= LayoutOptions.Center,
                    TextColor = Color.Maroon,
                    FontSize = 24,
                    FontAttributes = FontAttributes.Bold,
                    },

                    new Image { Source = "https://static.polskieszlaki.pl/zdjecia/wycieczki/2015-09/nowy-sacz-3.jpg"},

                    new Label
                    {Text="Zamek Królewski w Nowym Sączu – budowla wzniesiona przez króla Kazimierza Wielkiego w latach 1350–1360 na skarpie w obrębie fortyfikacji miejskich Nowego Sącza, w widłach dwóch rzek: Dunajca i Kamienicy. W przeszłości zamek posiadał dwie baszty narożne, wieżę, budynek mieszkalny i przedzamcze. Do dzisiaj zachowały się resztki murów obwodowych oraz zrekonstruowana Baszta Kowalska. Obecnie na terenie ruin zamku znajduje się park miejski. \n \n \nZamek królewski (Sądecz Nowy) położony był w drugiej połowie XVI wieku w powiecie sądeckim województwa krakowskiego.",
                    HorizontalOptions= LayoutOptions.CenterAndExpand,
                    TextColor = Color.Black,
                    FontSize = 16,
                    FontAttributes = FontAttributes.None,
                    HorizontalTextAlignment = TextAlignment.Start

                    },

                    openWikiZamek,
                    back_2

                }
            };

            stackLayoutPlanty = new StackLayout
            {

                Orientation = StackOrientation.Vertical,
                Spacing = 10,
                Padding = new Thickness(10),
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Children =
                {
                     new Label
                    {Text="Plany Nowy Sącz",
                    HorizontalOptions= LayoutOptions.Center,
                    TextColor = Color.Maroon,
                    FontSize = 24,
                    FontAttributes = FontAttributes.Bold,
                    },

                    new Image { Source = "https://www.beskidsadecki.eu/duzeIMG4/IMG_20160720_125831.jpg"},

                    new Label
                    {Text="Planty - stanowiące główny ogród miejski został utworzony w roku 1884. Znajdował się pomiędzy ówczesną ul. Węgierską a ul. Długosza. Park posiada patrona - Tadeusza Kościuszkę. Alejki i dworek znajdujący się w parku, który został zapisany na rzecz miasta przez byłego burmistrza dra Onufrego Trembeckiego, który życzył sobie, aby przeznaczyć go na miejską bibliotekę, park objął obszar po byłym cmentarzu położonym poza murami miasta, oraz teren po rozebranym kościele ze szpitalem. \n \nObecnie Planty to stylowy ogród z wiedeńskimi lampami, podświetlonymi alejkami i drzewami. ",
                    HorizontalOptions= LayoutOptions.CenterAndExpand,
                    TextColor = Color.Black,
                    FontSize = 16,
                    FontAttributes = FontAttributes.None,
                    HorizontalTextAlignment = TextAlignment.Start

                    },
                    openWikiPlanty,
                    back_3

                }
            };

            stackLayoutRatusz = new StackLayout
            {

                Orientation = StackOrientation.Vertical,
                Spacing = 10,
                Padding = new Thickness(10),
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Children =
                {
                      new Label
                    {Text="Ratusz",
                    HorizontalOptions= LayoutOptions.Center,
                    TextColor = Color.Maroon,
                    FontSize = 24,
                    FontAttributes = FontAttributes.Bold,
                    },

                    new Image { Source = "https://www.beskidsadecki.eu/duzeIMG4/IMG_20160720_123858_HDR.jpg"},

                    new Label
                    {Text="Najstarszym budynkiem, pełniącym funkcję ratusza był parterowy, murowany budynek zlokalizowany obok kościoła św. Małgorzaty. Ratusz ten został zakupiony z końcem lat 40. XV wieku przez kardynała Zbigniewa Oleśnickiego po utworzeniu Kolegiaty.Po sprzedaży budynku ratusza z przeznaczeniem dla wikarych Kolegiaty, jeszcze w połowie XV w. wzniesiono nową siedzibę władz miasta na centralnym placu, jakim był Rynek. W latach 1486, 1501 i 1523 był odbudowywany po częściowych pożarach. W latach 1562-63 został przebudowywany przez muratorów Lodovico I. i T., A. Lubelczyka, K. Kurzelowczyka i W. Barana oraz Mateusza z Krakowa w stylu renesansowym",
                    HorizontalOptions= LayoutOptions.CenterAndExpand,
                    TextColor = Color.Black,
                    FontSize = 16,
                    FontAttributes = FontAttributes.None,
                    HorizontalTextAlignment = TextAlignment.Start

                    },
                    openWikiRatusz,
                    back_4

                }
            };

            stackLayoutCmentarz = new StackLayout
            {

                Orientation = StackOrientation.Vertical,
                Spacing = 10,
                Padding = new Thickness(10),
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Children =
                {
                     new Label
                    {Text="Cmentarz komunalny",
                    HorizontalOptions= LayoutOptions.Center,
                    TextColor = Color.Maroon,
                    FontSize = 24,
                    FontAttributes = FontAttributes.Bold,
                    },

                    new Image { Source = "https://www.beskidsadecki.eu/duzeIMG2/cmentarz-komunalny.jpg"},

                    new Label
                    {Text="Został otwarty w roku 1889 i do dzisiaj to miejsce gdzie dawne groby przeplatają się z nowymi nagrobkami. Chociaż sądecki cmentarz ustępuje tym największym znanym cmentarzom europy, ma swój niepowtarzalny charakter. Możemy tutaj, w porównaniu do innych cmentarzy, zagłębić się nie w melancholii czy poczuć chłód, ale wręcz uspokojenie dzięki dużej ilości zieleni i jasności tego miejsca. Cmentarz liczy obecnie 6,3 hektara, gdzie na 82 kwaterach znajduje się przeszło 10 tys. grobów. Najstarszą częścią cmentarza jest cześć zlokalizowana przy ul. Rejtana. Spoczywają w niej zasłużenia dla Nowego Sącza mieszczanie, zmarli, którzy uczestniczyli w powstaniach oraz wojnach.",
                    HorizontalOptions= LayoutOptions.CenterAndExpand,
                    TextColor = Color.Black,
                    FontSize = 16,
                    FontAttributes = FontAttributes.None,
                    HorizontalTextAlignment = TextAlignment.Start

                    },
                    openWikiCmentarz,
                    back_5

                }
            };

            stackLayoutZegar = new StackLayout
            {

                Orientation = StackOrientation.Vertical,
                Spacing = 10,
                Padding = new Thickness(10),
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Children =
                {
                    new Label
                    {Text="Zegar kwiatowy",
                    HorizontalOptions= LayoutOptions.Center,
                    TextColor = Color.Maroon,
                    FontSize = 24,
                    FontAttributes = FontAttributes.Bold,
                    },

                    new Image { Source = "https://twojsacz.pl/wp-content/uploads/2014/05/zegar1.jpg", MinimumWidthRequest=400, MinimumHeightRequest=400 },
                    
                    new Label
                    {Text="Kwiatowy Zegar w Nowym Sączu znajduje się obok dawnych murów obronnych, ruin zamku oraz zachowanej w niezłym stanie do dziś Baszty Kowalskiej. Zegar wygląda interesująco i jest naprawdę sporych rozmiarów, a jego okrągły cyferblat jest wykonany z nasadzonych w tym miejscu kwiatów. Zegar chodzi i prawidłowo wskazuje godzinę! \n \n Zegar w Nowym Sączu może zmieniać swą tarczę zależnie od koloru rosnących tu kwiatów. Fajna ciekawostka turystyczna i miejsce spacerowe dla mieszkańców i turystów, bowiem zegar znajduje się przy szerokiej spacerowej alejce.",
                    HorizontalOptions= LayoutOptions.CenterAndExpand,
                    TextColor = Color.Black,
                    FontSize = 16,
                    FontAttributes = FontAttributes.None,
                    HorizontalTextAlignment = TextAlignment.Start
                    
                    },

                    openWikiZegar,
                    back_6

                }

            };

            ////////////////////////////////////////////////////////////////

            stackLayoutDworzec = new StackLayout
            {

                Orientation = StackOrientation.Vertical,
                Spacing = 10,
                Padding = new Thickness(10),
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Children =
                {
                    new Label
                    {Text="Dworzec PKP",
                    HorizontalOptions= LayoutOptions.Center,
                    TextColor = Color.Maroon,
                    FontSize = 24,
                    FontAttributes = FontAttributes.Bold,
                    },

                    new Image { Source = "https://twojsacz.pl/wp-content/uploads/2015/09/MIC_3242.jpg", MinimumWidthRequest=400, MinimumHeightRequest=400 },

                    new Label
                    {Text="DWORZEC PKP W NOWYM SĄCZU- jest przeważnie pierwszym obiektem, który może zobaczyć turysta przyjeżdżający w Beskid Sądecki - do Nowego Sącza. Pierwszy budynek dworca w mieście powstał w 1878 roku i była to jednopiętrowa budowla z przybudówkami. Podobne dworce wzniesiono również w tym czasie w Ptaszkowej, Bobowej i Ciężkowicach.Drugim budynkiem był dworzec wzniesiony przez projektantów austryjackich z cegły. Secesyjna budowla posiadała bogatą sztukaterię na przedniej ścianie. Datuje się ją na lata 1908 - 1909, czego dowodem może być data wyryta pod zegarem. Budynek stacji posiada bardzo obszerny hol główny. Jest on wysoki na dwie kondygnacje.",
                    HorizontalOptions= LayoutOptions.CenterAndExpand,
                    TextColor = Color.Black,
                    FontSize = 16,
                    FontAttributes = FontAttributes.None,
                    HorizontalTextAlignment = TextAlignment.Start

                    },

                    openwikiPKP,
                    back_7
                }

                };

            stackLayoutRezydencja = new StackLayout
            {

                Orientation = StackOrientation.Vertical,
                Spacing = 10,
                Padding = new Thickness(10),
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Children =
                {
                    new Label
                    {Text="Rezydencja Lubomirskich",
                    HorizontalOptions= LayoutOptions.Center,
                    TextColor = Color.Maroon,
                    FontSize = 24,
                    FontAttributes = FontAttributes.Bold,
                    },

                    new Image { Source = "https://polska-org.pl/foto/7355/Dom_nr_11_ul_Franciszkanska_Nowy_Sacz_7355215.jpg", MinimumWidthRequest=400, MinimumHeightRequest=400 },

                    new Label
                    {Text="Dom znajdujący się przy ulicy Franciszkańskiej 11 w Nowym Sączu został wzniesiony z polecenia Stanisława Lubomirskiego, w początkowych latach XVII wieku. Budynek posiada dekoracyjną elewację kamienną, a całość pokryta jest czterospadowym dachem. Budynek uległ zniszczeniu podczas pożaru w 1769 roku oraz podczas działań wojennych w Nowym Sączu, kiedy to doszło do wysadzenia pobliskiego zamku. Siła eksplozji dokonała dzieła zniszczenia rezydencji. W latach 1965-1970 został odrestaurowany. W rezydencji mieszkali głównie starostowie sadeccy z rodu Lubomirskich.",
                    HorizontalOptions= LayoutOptions.CenterAndExpand,
                    TextColor = Color.Black,
                    FontSize = 16,
                    FontAttributes = FontAttributes.None,
                    HorizontalTextAlignment = TextAlignment.Start

                    },

                    openwikiRezydencja,
                    back_8
                }

            };


            stackLayoutSynagoga = new StackLayout
            {

                Orientation = StackOrientation.Vertical,
                Spacing = 10,
                Padding = new Thickness(10),
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Children =
                {
                    new Label
                    {Text="Dawna Synagoga",
                    HorizontalOptions= LayoutOptions.Center,
                    TextColor = Color.Maroon,
                    FontSize = 24,
                    FontAttributes = FontAttributes.Bold,
                    },

                    new Image { Source = "https://twojsacz.pl/wp-content/uploads/2015/08/synagoga3.jpg", MinimumWidthRequest=400, MinimumHeightRequest=400 },

                    new Label
                    {Text="DAWNA SYNAGOGA W NOWYM SĄCZU- została wzniesiona w 1746 roku za sprawą starosty Jerzego Lubomirskiego. Stanęła ona na miejscu dawnej, drewnianej synagogi w Nowym Sączu. Budowla miała nie być wyższa od najniższego sądeckiego kościoła oraz powinna być wzorowana na synagogach z Chełma i Chęcin. Pożar, który wybuchł w 1894 roku doszczętnie zniszczył jej wnętrze, jednak solidne mury pozostały nienaruszone. Wkrótce została ponownie odbudowana z nowymi cechami architektonicznymi, które są widoczne do dnia dzisiejszego. Podczas działań wojennych synagogę doszczętnie zdewastowano a hitlerowcy urządzili w jej wnętrzach magazyn mienia pożydowskiego.",
                    HorizontalOptions= LayoutOptions.CenterAndExpand,
                    TextColor = Color.Black,
                    FontSize = 16,
                    FontAttributes = FontAttributes.None,
                    HorizontalTextAlignment = TextAlignment.Start

                    },

                    openwikiSynagoga,
                    back_9
                }

            };

            stackLayoutDGotycki = new StackLayout
            {

                Orientation = StackOrientation.Vertical,
                Spacing = 10,
                Padding = new Thickness(10),
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Children =
                {
                    new Label
                    {Text="Dom Gotycki",
                    HorizontalOptions= LayoutOptions.Center,
                    TextColor = Color.Maroon,
                    FontSize = 24,
                    FontAttributes = FontAttributes.Bold,
                    },

                    new Image { Source = "https://polska-org.pl/foto/7351/Dom_Gotycki_ul_Lwowska_Nowy_Sacz_7351072.jpg", MinimumWidthRequest=400, MinimumHeightRequest=400 },

                    new Label
                    {Text="DOM GOTYCKI W NOWYM SĄCZU- zwany również Domem Kanonicznym powstał na przełomie XV i XVI wieku. Położony był w granicach miasta lokacyjnego, przy ulicy Lwowskiej i Św. Ducha.Obecnie budynek Domu Kanonicznego wykorzystywany jest jako Muzeum Okręgowe od renowacji w latach 1959-1965. Obecnie jest własnością parafii Św. Małgorzaty, która pozostawiła go do dyspozycji Muzeum za symboliczną złotówkę. Sam budynek jest konstrukcją murowaną, zbudowaną z łamanego kamienia. Całość jest podpiwniczona. Powstał on z połączenia trzech kamienic: rezydencji dziekana, wikarówki i domu starszych samotnych kobiet i wdów. Jego powierzchnia plasuje go na 4 miejscu w Polsce",
                    HorizontalOptions= LayoutOptions.CenterAndExpand,
                    TextColor = Color.Black,
                    FontSize = 16,
                    FontAttributes = FontAttributes.None,
                    HorizontalTextAlignment = TextAlignment.Start

                    },

                    openwikiDGotycki,
                    back_10
                }

            };

            stackLayoutKapliczka = new StackLayout
            {

                Orientation = StackOrientation.Vertical,
                Spacing = 10,
                Padding = new Thickness(10),
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Children =
                {
                    new Label
                    {Text="Kapliczka Szwedzka",
                    HorizontalOptions= LayoutOptions.Center,
                    TextColor = Color.Maroon,
                    FontSize = 24,
                    FontAttributes = FontAttributes.Bold,
                    },

                    new Image { Source = "https://www.beskidsadecki.eu/duzeIMG4/IMG_20160720_125106_HDR.jpg", MinimumWidthRequest=400, MinimumHeightRequest=400 },

                    new Label
                    {Text="KAPLICZKA SZWEDZKA W NOWYM SĄCZU - pw. Św. Marka została wzniesiona w 1771 roku zaraz za murem miejskim, w miejscu pochówki Szwedów w 1655. Zginęli oni w walkach o miasto. Obecnie znajduje się ona na skrzyżowaniu ul. Jagiellońskiej i Kościuszki. Całość budowli jest murowana, otynkowana i pokryta dachem namiotowym. Całość zakończona jest kwadratową wieżyczką. Ściany zewnętrzne opilastrowane. W jej środku umieszczono rzeźbę Chrystusa Frasobliwego, wykonaną przez miejscową ludność. Do kapliczki prowadza kamienne schody, które są zabezpieczone artystycznie wykonaną metalową balustradą. ",
                    HorizontalOptions= LayoutOptions.CenterAndExpand,
                    TextColor = Color.Black,
                    FontSize = 16,
                    FontAttributes = FontAttributes.None,
                    HorizontalTextAlignment = TextAlignment.Start

                    },

                    openwikiKapliczka,
                    back_11
                }

            };

            stackLayoutSokol = new StackLayout
            {

                Orientation = StackOrientation.Vertical,
                Spacing = 10,
                Padding = new Thickness(10),
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Children =
                {
                    new Label
                    {Text="Sokół",
                    HorizontalOptions= LayoutOptions.Center,
                    TextColor = Color.Maroon,
                    FontSize = 24,
                    FontAttributes = FontAttributes.Bold,
                    },

                    new Image { Source = "https://polska-org.pl/foto/7360/Malopolskie_Centrum_Kultury_Sokol_ul_Dlugosza_Jana_Nowy_Sacz_7360562.jpg", MinimumWidthRequest=400, MinimumHeightRequest=400 },

                    new Label
                    {Text="SOKÓŁ W NOWYM SĄCZU- jest, zaraz po ratuszu budynkiem typowo świeckim, którego historia przeplata się z historią miasta. Był on świadkiem wielu wyniosłych i dramatycznych wydarzeń. Od 1892 roku kiedy został wzniesiony pełnił przez jakiś czas funkcję magistratu, podczas odbudowy ratusza, który spłonął w 1894 roku. Od 1911 roku gmach służy jako kino ( to tutaj powstała pierwsza w Galicji operatornia kinowa). Budynek Sokoła to parterowy gmach, który został wybudowany na dawnym placu po zwierzęcej targowicy. Przylegała ona do Ogrodu Miejskiego, które dzisiaj zwane są Plantami. undatorami byli członkowie Towarzystwa Gimnastycznego Sokół, którzy wybudowali gmach na 600-lecie Nowego Sącza. Budowa gmachu trwał 5 miesięcy i została zakończona 8 listopada 1892 roku.",
                    HorizontalOptions= LayoutOptions.CenterAndExpand,
                    TextColor = Color.Black,
                    FontSize = 16,
                    FontAttributes = FontAttributes.None,
                    HorizontalTextAlignment = TextAlignment.Start

                    },

                    openwikiSokol,
                    back_12
                }

            };
























            Content = stackLayout;

        //InitializeComponent();
        }

        

        private void OpenSokol_Clicked(object sender, EventArgs e)
        {
            Content = stackLayoutSokol;
        }

        private void OpenKapliczka_Clicked(object sender, EventArgs e)
        {
            Content = stackLayoutKapliczka;
        }

        private void OpenDGotycki_Clicked(object sender, EventArgs e)
        {
            Content = stackLayoutDGotycki;
        }

        private void OpenSynagoga_Clicked(object sender, EventArgs e)
        {
            Content = stackLayoutSynagoga;
        }

        private void OpenRezydencja_Clicked(object sender, EventArgs e)
        {
            Content = stackLayoutRezydencja;
        }

        private void OpenPKP_Clicked(object sender, EventArgs e)
        {
            Content = stackLayoutDworzec;
        }

        private void OpenWikiZegar_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://pl.wikipedia.org/wiki/Nowy_S%C4%85cz"));
        }

        private void OpenWikiCmentarz_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("http://www.beskidsadecki.eu/index.php?id=sadecki_NowySacz&sk=komunalny-cmentarz"));
        }

        private void OpenWikiZamek_Clicked1(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://pl.wikipedia.org/wiki/Bazylika_kolegiacka_%C5%9Bw._Ma%C5%82gorzaty_w_Nowym_S%C4%85czu"));
        }

        

        private void OpenWikiRatusz_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://pl.wikipedia.org/wiki/Ratusz_w_Nowym_S%C4%85czu"));
        }
              

        private void OpenWikiPlanty_Clicked1(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("http://www.beskidsadecki.eu/index.php?id=sadecki_NowySacz&sk=park"));
        }
      

        private void OpenWikiZamek_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://pl.wikipedia.org/wiki/Zamek_Kr%C3%B3lewski_w_Nowym_S%C4%85czu"));
        }

        private void OpenWikiBazylika_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://pl.wikipedia.org/wiki/Bazylika_kolegiacka_%C5%9Bw._Ma%C5%82gorzaty_w_Nowym_S%C4%85czu"));
           
        }
    
        private void OpenwikiSokol_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://pl.wikipedia.org/wiki/Ma%C5%82opolskie_Centrum_Kultury_Sok%C3%B3%C5%82"));
        }

        private void OpenwikiKapliczka_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("http://www.beskidsadecki.eu/index.php?id=sadecki_NowySacz&sk=kapliczkaszwedzka"));
        }

        private void OpenwikiDGotycki_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://pl.wikipedia.org/wiki/Dom_Gotycki_w_Nowym_S%C4%85czu"));
        }

        private void OpenwikiSynagoga_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://pl.wikipedia.org/wiki/Synagoga_w_Nowym_S%C4%85czu"));
        }

        private void OpenwikiRezydencja_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("http://www.beskidsadecki.eu/index.php?id=sadecki_NowySacz&sk=RezydencjaLubomirskich"));
        }

        private void OpenwikiPKP_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://pl.wikipedia.org/wiki/Nowy_S%C4%85cz_(stacja_kolejowa)"));
        }


        private void OpenZegar_Clicked(object sender, EventArgs e)
        {
            Content = stackLayoutZegar;
        }

        private void OpenCmentarz_Clicked(object sender, EventArgs e)
        {
            Content = stackLayoutCmentarz;
        }

        private void OpenZamek_Clicked(object sender, EventArgs e)
        {
            Content = stackLayoutZamek;
        }

        private void OpenPlanty_Clicked1(object sender, EventArgs e)
        {
            Content = stackLayoutPlanty;
        }

        private void OpenBazylika_Clicked(object sender, EventArgs e)
        {
            Content = stackLayoutBazylika;
           
        }

        private void OpenRatusz_Clicked(object sender, EventArgs e)
        {
            Content = stackLayoutRatusz;
        }


        private void Back_Clicked(object sender, EventArgs e)
        {
            Content = stackLayout;
        }

        private void Back_2_Clicked(object sender, EventArgs e)
        {
            Content = stackLayout;
        }
        
        private void Back_3_Clicked(object sender, EventArgs e)
        {
            Content = stackLayout;
        }

        private void Back_4_Clicked(object sender, EventArgs e)
        {
            Content = stackLayout;
        }

        private void Back_5_Clicked(object sender, EventArgs e)
        {
            Content = stackLayout;
        }

        private void Back_6_Clicked(object sender, EventArgs e)
        {
            Content = stackLayout;
        }
        private void Back_12_Clicked(object sender, EventArgs e)
        {
            Content = stackLayout;
        }

        private void Back_11_Clicked(object sender, EventArgs e)
        {
            Content = stackLayout;
        }

        private void Back_10_Clicked(object sender, EventArgs e)
        {
            Content = stackLayout;
        }

        private void Back_8_Clicked(object sender, EventArgs e)
        {
            Content = stackLayout;
        }

        private void Back_7_Clicked(object sender, EventArgs e)
        {
            Content = stackLayout;
        }

        private void Back_9_Clicked(object sender, EventArgs e)
        {
            Content = stackLayout;
        }

    }
}