using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace Teste001
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MapPage1 : ContentPage
    {
        Map map = null;

        public MapPage1()
        {
            InitializeComponent();

            Button btn = new Button()
            {
                Text = "Clique"
            };

            btn.Clicked += Btn_Clicked;

            map = new Map()
            {
                IsShowingUser = true,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

            Content = new StackLayout
            {
                Children = { btn, map }
            };

            
        }

        private async void Btn_Clicked(object sender, EventArgs e)
        {
            //throw new NotImplementedException();

            if (map == null)
                return;

            Position position = new Position(-23.497096, -46.154320);
            map.MoveToRegion(new MapSpan(position, 0.01, 0.01));
            map.Pins.Add(new Pin() { Label = "CASA", Position = position });
            
        }





        private async Task test_001(Map map)
        {
            Geocoder geocoder = new Geocoder();

            IEnumerable<Position> positions = await
                geocoder.GetPositionsForAddressAsync(
                    "Eudoxia castelo branco 793");

            foreach (var item in positions)
                map.Pins.Add(new Pin() { Position = item });

            Position position = new Position(
                map.Pins[0].Position.Latitude,
                map.Pins[0].Position.Longitude);

            map.MoveToRegion(
                MapSpan.FromCenterAndRadius(
                    position, Distance.FromKilometers(5)));
        }



    }// class
}// namespace