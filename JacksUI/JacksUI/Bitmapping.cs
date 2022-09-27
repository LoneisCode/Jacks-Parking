using System;
using System.Drawing;
//using Microsoft.Maui.Graphics;
using SkiaSharp;
using System.Runtime;


namespace JacksUI
{
    public class Bitmapping
    {
        //System.Drawing.Image lot = new Image { Source = "/Resources/Images/lotImage.jpg" };
        //Bitmap lotImage = BitmapFactory.DecodeFile("/Resources/Images/lotImage.jpg");

        //System.Drawing.Image lot = Image.
        /*static Microsoft.Maui.Controls.Image image = new Microsoft.Maui.Controls.Image
        {
            Source = ImageSource.FromFile("Resources/images/lot_image.png")
        };*/
        //Image im = Image.FromFile
        //Stream s = new Stream();
        static SKImage lotImage = SKImage.FromEncodedData("C:\\lot_image.jpg");
        static SKImageInfo imageInfo = new SKImageInfo(4000, 3000);
        ////static SKImage UIImage = SKImage.Create(imageInfo);
        static SKBitmap lot = SKBitmap.FromImage(lotImage); //UIImage.FromFile("/Resources/Images/lotImage.jpg").ToSKBitmap();
                                                                                     //static Bitmap lotImage = new(image);
                                                                                     //
         //returns the R values of the diagonal pixels. Hardcoded for one spot.
         public static byte[] getR()
         {
             int x = 2333;
             int y = 2297;
             byte[] rValues = new byte[120];

             for (int i = 0; i < 120; i++)
             {
                 SkiaSharp.SKColor c = lot.GetPixel(x, y);
                 rValues[i] = c.Red;
                 x += 2;
                 y -= 2;
             }
             Console.WriteLine(rValues[0]);
             return rValues;
         }

         //returns the G values of the diagonal pixels. Hardcoded for one spot.
         public static byte[] getG()
         {
             int x = 2333;
             int y = 2297;
             byte[] gValues = new byte[120];

             for (int i = 0; i < 120; i++)
             {
                SkiaSharp.SKColor c = lot.GetPixel(x, y);
                gValues[i] = c.Green;
                 x += 2;
                 y -= 2;
             }
             Console.WriteLine(gValues[0]);
             return gValues;
         }

         //returns the B values of the diagonal pixels. Hardcoded for one spot.
         public static byte[] getB()
         {
             int x = 2333;
             int y = 2297;
             byte[] bValues = new byte[120];

             for (int i = 0; i < 120; i++)
             {
                SkiaSharp.SKColor c = lot.GetPixel(x, y);
                bValues[i] = c.Blue;
                 x += 2;
                 y -= 2;
             }
             Console.WriteLine(bValues[0]);
             return bValues;
         }
    }
}
