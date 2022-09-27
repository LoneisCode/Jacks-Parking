using System.Linq;
using System;

namespace JacksUI
{

	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}
		private void OnCounterClicked(object sender, EventArgs e)
		{

			double[] colorArr = { 10, 12, 23, 23, 16, 23, 21, 16 };

			Bitmapping bitmapping = new Bitmapping();

			bitmapping.getR();
			bitmapping.getG();
			bitmapping.getB();

			CounterBtn.Text = Calculations.ConfidenceInterval(colorArr).ToString();

			SemanticScreenReader.Announce(CounterBtn.Text);
		}
	}
}

