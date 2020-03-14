using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace CustomRenderer
{
    public class MapPageCS : ContentPage
    {
        public MapPageCS()
        {

            CustomMap customMap = new CustomMap
            {
                MapType = MapType.Street
            };

            // var position = await Plugin.Geolocator.CrossGeolocator.Current.GetPositionAsync();
            // MyPosition = new Position(position.Latitude, position.Longitude);

            CustomPin pin = new CustomPin
            {
                Type = PinType.Place,
                Position = new Position(37.79752, -122.40183),
                Label = "Anywhere",
                Address = "CS",
                Name = "Cas",
                Url = "http://google.com/"
            };

            customMap.CustomPins = new List<CustomPin> { pin };
            customMap.Pins.Add(pin);
            customMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(37.79752, -122.40183), Distance.FromMiles(1.0)));

            Content = customMap;
        }
    }
}
