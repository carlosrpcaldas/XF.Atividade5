using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Maps;

namespace Teste001
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MapPage : ContentPage
    {
        public MapPage()
        {
            InitializeComponent();

            preenche_estacionamentos_cadastrados();
        }

        //
        // Métodos
        //

        private async void preenche_estacionamentos_cadastrados()
        {
            foreach (Modelo.Estacionamento item in Modelo.Estacionamento.recupera_estacionamentos())
            {
                MapManager mm = new MapManager(map);
                IEnumerable<Position> posicoes = await mm.FindAddress(item.endereco);

                foreach (var pos in posicoes)
                    map.Pins.Add(new Pin
                    {
                        Type = PinType.Generic,
                        Position = pos,
                        Label = ""
                    });
            }
        }

        private async void busca_endereco_insere_pin_mapa(string endereco)
        {
            MapManager mm = new MapManager(map);
            IEnumerable<Position> pos = await mm.FindAddress(endereco);
            mm.AddLocationPins(pos);
        }

        //
        // Eventos
        //

        private void searchbar_SearchButtonPressed(object sender, EventArgs e)
        {
            busca_endereco_insere_pin_mapa(searchbar.Text);
        }

    }// class
}// namespace