using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace MapsApp
{
    public partial class CustomMapPage : ContentPage
    {
        public CustomMapPage()
        {
            InitializeComponent();

            var map = new Map(MapSpan.FromCenterAndRadius(
                new Position(49.619335, 20.698595), Distance.FromMiles(0.75)))
            {
                IsShowingUser = true,
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            var position1 = new Position(49.625150, 20.692775);
            var position2 = new Position(49.625247, 20.690861);
            var position3 = new Position(49.628702, 20.689008);
            var position4 = new Position(49.628726, 20.690247);
            var position5 = new Position(49.620495, 20.694799);
            var position6 = new Position(49.616928, 20.704588);

            var position7 = new Position(49.606776, 20.702306);//Pkp

            var position8 = new Position(49.626263, 20.690385);//Rezydencja 

            var position9 = new Position(49.627790, 20.690492);//synagoga 

            var position10 = new Position(49.625014, 20.693392); //dom gotycki

            var position11 = new Position(49.623370, 20.692184);//kapliczka 

            var position12 = new Position(49.622277, 20.695019);//Sokół



            var pin1 = new Pin
            {
                Type = PinType.Place,
                Position = position1,
                Label = "Bazylika",
                Address = "www.intilaq.tn",
            };

            var pin2 = new Pin
            {
                Type = PinType.Place,
                Position = position2,
                Label = "Ratusz",
                Address = "www.groupe-telnet.com"
            };

            var pin3 = new Pin
            {
                Type = PinType.Place,
                Position = position3,
                Label = "Ruiny Zamku Królewskiego",
                Address = "www.kromberg-schubert.com"
            };

            var pin4 = new Pin
            {
                Type = PinType.Place,
                Position = position4,
                Label = "Zegar kwiatowy",
                Address = "www.kromberg-schubert.com"
            };

            var pin5 = new Pin
            {
                Type = PinType.Place,
                Position = position5,
                Label = "Planty",
                Address = "Planty "
                
            };

            var pin6 = new Pin
            {
                Type = PinType.Place,
                Position = position6,
                Label = "Cmentarz Komunalny",
                Address = "www.kromberg-schubert.com"
            };


            var pin7 = new Pin
            {
                Type = PinType.Place,
                Position = position7,
                Label = "Dworzec PKP",
                Address = "www.intilaq.tn",
            };

            var pin8= new Pin
            {
                Type = PinType.Place,
                Position = position8,
                Label = "Rezydencja Lubomirskich",
                Address = "www.groupe-telnet.com"
            };

            var pin9 = new Pin
            {
                Type = PinType.Place,
                Position = position9,
                Label = "Dawna Synagoga",
                Address = "www.kromberg-schubert.com"
            };

            var pin10 = new Pin
            {
                Type = PinType.Place,
                Position = position10,
                Label = "Dom Gotycki",
                Address = "www.kromberg-schubert.com"
            };

            var pin11 = new Pin
            {
                Type = PinType.Place,
                Position = position11,
                Label = "Kapliczka Szwedzka",
                Address = "Planty "

            };

            var pin12 = new Pin
            {
                Type = PinType.Place,
                Position = position12,
                Label = "Sokół",
                Address = "www.kromberg-schubert.com"
            };




            map.Pins.Add(pin1);
            map.Pins.Add(pin2);
            map.Pins.Add(pin3);
            map.Pins.Add(pin4);
            map.Pins.Add(pin5);
            map.Pins.Add(pin6);
            map.Pins.Add(pin7);
            map.Pins.Add(pin8);
            map.Pins.Add(pin9);
            map.Pins.Add(pin10);
            map.Pins.Add(pin11);
            map.Pins.Add(pin12);

            Content = map;
        
    }
    }
}
