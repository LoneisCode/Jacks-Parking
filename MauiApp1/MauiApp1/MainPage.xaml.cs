using Android.OS;
using Microsoft.Data.Sqlite;
using Microsoft.Maui.Controls.Maps;
using Microsoft.Maui.Maps;
using System.Reflection;

namespace MauiApp1;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();

        //TODO only do this when app first runs 
        /* var assembly = IntrospectionExtensions.GetTypeInfo(typeof(App)).Assembly;
         using (Stream stream =
                assembly.GetManifestResourceStream("MauiApp1.JacksParkingSQLiteDB.db")) {
             using (MemoryStream memoryStream = new MemoryStream()) {
                 stream.CopyTo(memoryStream);

                 File.WriteAllBytes(Accessdbfe.CreateConnection(), memoryStream.ToArray());
             }
         }*/

        string output = Accessdbfe.ReadData(Accessdbfe.CreateConnection(), 1);
        
        //System.WriteLine(output);
      
	}

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);


        var sfa = new Location(31.6216, -94.6466);
        var villageLot = new Location(31.616634, -94.650789);
        MapSpan mapSpan = MapSpan.FromCenterAndRadius(sfa, Distance.FromKilometers(3));
        mapSpan = mapSpan.WithZoom(5);
        map.MoveToRegion(mapSpan);
        map.Pins.Add(new Pin
        {
            Label = "Welcome to Jacks Parking",
            Location = sfa,
        });
        map.Pins.Add(new Pin
        {
            Label = "Village Lot",
            Location = villageLot,
        });
    }

}

