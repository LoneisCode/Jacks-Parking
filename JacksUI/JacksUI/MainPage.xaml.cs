using System.Linq;
using System;
using System.Drawing;
//using Android.Graphics;

namespace JacksUI;

public partial class MainPage : ContentPage
{
    //System.Drawing.Image lot = new Image { Source = "/Resources/Images/lotImage.jpg" };
    //Bitmap lotImage = BitmapFactory.DecodeFile("/Resources/Images/lotImage.jpg");


    Bitmap lotImage = new Bitmap("/Resources/Images/lotImage.jpg");

    public MainPage()
	{
		InitializeComponent();
	}

	
	//returns the R values of the diagonal pixels. Hardcoded for one spot.
	public byte[] getR()
	{
		int x = 2333;
		int y = 2297;
		byte[] rValues = new byte[120];

		for (int i = 0; i < 120; i++)
		{
			System.Drawing.Color c = lotImage.GetPixel(x, y);
			rValues[i] = c.R;
			x += 2;
			y -= 2;
		}

		return rValues;
	}

    //returns the G values of the diagonal pixels. Hardcoded for one spot.
    public byte[] getG()
    {
        int x = 2333;
        int y = 2297;
        byte[] gValues = new byte[120];

        for (int i = 0; i < 120; i++)
        {
            System.Drawing.Color c = lotImage.GetPixel(x, y);
            gValues[i] = c.G;
            x += 2;
            y -= 2;
        }

        return gValues;
    }

    //returns the B values of the diagonal pixels. Hardcoded for one spot.
    public byte[] getB()
    {
        int x = 2333;
        int y = 2297;
        byte[] bValues = new byte[120];

        for (int i = 0; i < 120; i++)
        {
            System.Drawing.Color c = lotImage.GetPixel(x, y);
            bValues[i] = c.B;
            x += 2;
            y -= 2;
        }

        return bValues;
    }


    //Input: Array of Red values, Array of Blue values, or Array of Green values
    //Output: Population Standard Deviation
    public static double standardDeviation(double[] colorArr, double mean)
    {
        double sum = colorArr.Sum(d => Math.Pow(d - mean, 2));
		return Math.Sqrt((sum) / colorArr.Count());
		
    }

	public static double[] ConfidenceInterval(double[] colorArr) {
		double[] result = new double[2];
		double mean = colorArr.Average();
		int sampleSize = colorArr.Length - 1;
		double sd = standardDeviation(colorArr, mean);
		double lowerBound = mean - (Constants.confidenceLevel_99 * (sd / Math.Sqrt(sampleSize)));
		double upperBound = mean + (Constants.confidenceLevel_99 * (sd / Math.Sqrt(sampleSize)));

		result[0] = lowerBound;
		result[1] = upperBound;

		return result;
	}


    private void OnCounterClicked(object sender, EventArgs e)
	{

		double[] colorArr = { 10, 12, 23, 23, 16, 23, 21, 16 };

		CounterBtn.Text = ConfidenceInterval(colorArr).ToString();

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}

