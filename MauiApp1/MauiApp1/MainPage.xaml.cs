using Microsoft.Data.Sqlite;
using Microsoft.Maui.Controls.Maps;
using Microsoft.Maui.Maps;

namespace MauiApp1;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);

        SqliteConnection sqliteConn;
        sqliteConn = Accessdbfe.CreateConnection();
        sqliteConn.Open();
        string outut = Accessdbfe.ReadData(sqliteConn, 1);


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

