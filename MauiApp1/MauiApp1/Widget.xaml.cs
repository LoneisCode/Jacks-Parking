namespace MauiApp1;

public partial class Widget : ContentView
{
    public Widget()
    {
        InitializeComponent();
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