using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;

namespace GoogleMaps
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            // Use this for multiple pins
            GeneratePins();
            // Use this for a single pin
            //var pin = new Pin { Type = PinType.Place, Label = "This is my home", Address = "Here", Position = new Position(-23.68, -46.87) };
            //map.Pins.Add(pin);
        }

        private void GeneratePins()
        {
            var pins = new List<Pin>
            {
                new Pin { Type = PinType.Place, Label = "This is my home", Address = "Here", Position = new Position(-23.68, -46.87) },
                new Pin { Type = PinType.Place, Label = "This is my home", Address = "Here", Position = new Position(-23.68, -46.77) },
                new Pin { Type = PinType.Place, Label = "This is my home", Address = "Here", Position = new Position(-23.68, -46.97) },
            };

            foreach (var pin in pins)
            {
                // We can use FromBundle, FromStream or FromView
                pin.Icon = BitmapDescriptorFactory.FromBundle("coffee_pin.png");
                map.Pins.Add(pin);
            }
        }
    }
}
