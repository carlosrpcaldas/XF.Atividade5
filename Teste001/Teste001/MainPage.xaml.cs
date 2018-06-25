using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Teste001
{
    public class Person
    {
        public string name { get; set; }
        public string last_name { get; set; }
        public DateTime dtBorn{ get; set; }
    }

    public partial class MainPage : ContentPage
    {
        private List<Person> peoples = new List<Person>()
        {
            new Person() { name = "Abigail", dtBorn = new DateTime(1975, 01, 15) },
            new Person() { name = "Bob",     dtBorn = new DateTime(1976, 02, 20) },
            new Person() { name = "Yvonne",  dtBorn = new DateTime(1987, 01, 10) },
            new Person() { name = "Zachary", dtBorn = new DateTime(1988, 02, 05) },
        };
            

        public MainPage()
        {
            InitializeComponent();

            //insere_layout_na_pagina();

            entry.TextChanged += MyAutoComplete_TextChanged;
        }

        private void insere_layout_na_pagina()
        {
            Label header = new Label
            {
                Text = "Button",
                Font = Font.BoldSystemFontOfSize(50),
                HorizontalOptions = LayoutOptions.Center
            };

            Button button = new Button
            {
                BorderWidth = 1,
                Text = "Click Me!",
                Font = Font.SystemFontOfSize(NamedSize.Large),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            button.Clicked += OnButtonClicked;

            // Build the page.
            this.Content = new StackLayout
            {
                Children =
                {
                    header,
                    button
                }
            };
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            ////tel:1112223333
            ////http://maps.google.com/?daddr=37.788463,-122.392545
            ////http://maps.apple.com/?daddr=37.788463,-122.392545

            string s = string.Format(
                "http://maps.google.com/?daddr={0},{1}",
                "37.788463", "-122.392545");

            Uri uri = new Uri(s);
            Device.OpenUri(uri);
        }

        //private async void OnGPSClicked(object sender, EventArgs e)
        //{
        //    lblGpsSearch.Text = "Buscando posição...";
        //    var objCoordinate = await DependencyService.Get<IGps>().GetPosition();
        //    if (objCoordinate != null){
        //        lblGpsSearch.Text = "Posição válida!";
        //        lblGpsLatitude.Text = "Latitude: " + objCoordinate.Latitude.ToString();
        //        lblGpsLongitude.Text = "Longitude: " + objCoordinate.Longitude.ToString();
        //    }
        //}


        void MyAutoComplete_TextChanged(object sender, TextChangedEventArgs e)
        {
            string txt_entry = entry.Text.ToLower();
            
            this.listview.ItemsSource = peoples.Where(
                x => x.name.ToLower().Contains(txt_entry)).ToList();

            this.listview.IsVisible = true;
        }

    }// class
}// namespace
