using System;
using System.Transactions;

namespace JacksParkingBackEnd
{
    public class ParkingSpot
    {
        private int topX;
        private int topY;
        private int bottomX;
        private int bottomY;
        private int length;
        private int xRange;
        private double slope;
        private double yIntercept;
        private double[] red;
        private double[] green;
        private double[] blue;
        private bool isTopLeft;


        public ParkingSpot(int topX, int topY, int bottomX, int bottomY, bool isTopLeft)
        {
            this.topX = topX;
            this.bottomY = bottomY;
            this.topY = topY;
            this.bottomX = bottomX;
            xRange = Math.Abs(topX - bottomX);
            // Distance formula
            this.length = (int)Math.Sqrt(Math.Pow((double)(topX - bottomX), 2) + Math.Pow((double)(topY - bottomY), 2)); 
            this.slope = Math.Round(((double)topY - (double)bottomY) / ((double)topX - (double)bottomX), 7);
            this.yIntercept = (this.topY) - (this.slope * this.topX);
            this.isTopLeft = isTopLeft;
        }

        public bool GetIsTopLeft()
        {
            return this.isTopLeft;
        }

        public int GetXRange()
        {
            return this.xRange;
        }
        public void SetR(double[] red)
        {
            this.red = red;
        }

        public void SetG(double[] green)
        {
            this.green = green;
        }

        public void SetB(double[] blue)
        {
            this.blue = blue;
        }

        public int GetBottomX()
        {
            return this.bottomX;
        }

        public int GetBottomY()
        {
            return this.bottomY;
        }

        public int GetTopX()
        {
            return this.topX;
        }

        public int GetTopY()
        {
            return this.topY;
        }

        public int GetLength()
        {
            return this.length;
        }

        public double[] GetRed()
        {
            return this.red;
        }

        public double[] GetBlue()
        {
            return this.blue;
        }
        public double[] GetGreen()
        {
            return this.green;
        }

        public double GetSlope()
        {
            return this.slope;
        }

        public double GetYIntercept()
        {
            return this.yIntercept;
        }

    }
}
