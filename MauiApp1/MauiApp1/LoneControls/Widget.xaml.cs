namespace MauiApp1;

public partial class Widget : ContentView
{
    public Widget()
    {
        InitializeComponent();
        string[] output = Accessdbfe.ReadData(Accessdbfe.CreateConnection(), 1);
        parkingLotName.Text =  output[7];
        string prevCounttxt = SpotCount.Text;
        SpotCount.Text = prevCounttxt + output[3];
    }

    bool drawerUp = true;
    
    private void SwipeGestureRecognizer_Swiped(object sender, SwipedEventArgs e)
    {

        if (drawerUp)
        {
            WidgetBase.TranslationY = 185;
            drawerUp = false;
        }
        else
        {
            WidgetBase.TranslationY = 7;
            drawerUp = true;
        }
           

    }


}