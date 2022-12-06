using MauiApp1.modelViews;

namespace MauiApp1;

public partial class Filter : ContentView
{
	public Filter()
	{
		InitializeComponent();
		BindingContext = new FilterViewModel();
	}

    private void ImageButton_Clicked(object sender, EventArgs e)
    {
		if(filterPicker.IsVisible == false)
		{
			filterPicker.IsVisible = true;
		}
		else
		{
			filterPicker.IsVisible = false;
		}
    }
}