using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Plugin.Geolocator;

namespace CustomRenderer
{
    public partial class MapBuild : ContentPage
    {
        public MapBuild()
        {
            InitializeComponent();

            buildMap();
        }

        public async void buildMap()
        {
            var locator = CrossGeolocator.Current;
            var position = await locator.GetPositionAsync();

            double latitude = position.Latitude;
            double longitude = position.Longitude;

            CustomMap customMap = new CustomMap
            {
                MapType = MapType.Street
            };

            CustomPin pin = new CustomPin
            {
                Type = PinType.Place,
                Position = new Position(latitude, longitude),
                Label = "Anywhere",
                Address = "CS",
                Name = "Cas",
                Url = "http://google.com/"
            };

            customMap.CustomPins = new List<CustomPin> { pin };
            customMap.Pins.Add(pin);
            customMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(latitude, longitude), Distance.FromMiles(1.0)));
            // new Position(37.79752, -122.40183), Distance.FromMiles(1.0))


        }

    }


}
