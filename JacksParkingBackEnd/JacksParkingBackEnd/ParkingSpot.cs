using System;
using System.Linq;
using System.Transactions;

namespace JacksParkingBackEnd
{
    public class ParkingSpot
    {
        private int topLeftX;
        private int topLeftY;
        private int topRightX;
        private int topRightY;
        private int bottomLeftX;
        private int bottomLeftY;
        private int bottomRightX;
        private int bottomRightY;
        //private int bottomX;
        //private int bottomY;
        private int length;
        private int xRange;
        private double slope;
        private double yIntercept;
        private double[] red;
        private double[] green;
        private double[] blue;
        private bool isTopLeft;
        private int maxX;
        private int maxY;
        private int minX;
        private int minY;


        //public ParkingSpot(int topX, int topY, int bottomX, int bottomY, bool isTopLeft)
        //{
        //    this.topX = topX;
        //    this.bottomY = bottomY;
        //    this.topY = topY;
        //    this.bottomX = bottomX;
        //    xRange = Math.Abs(topX - bottomX);
        //    // Distance formula
        //    this.length = (int)Math.Sqrt(Math.Pow((double)(topX - bottomX), 2) + Math.Pow((double)(topY - bottomY), 2)); 
        //    this.slope = Math.Round(((double)topY - (double)bottomY) / ((double)topX - (double)bottomX), 7);
        //    this.yIntercept = (this.topY) - (this.slope * this.topX);
        //    this.isTopLeft = isTopLeft;
        //}

        public ParkingSpot(int topLeftX, int topLeftY, int topRightX, int topRightY, int bottomLeftX, int bottomLeftY, int bottomRightX, int bottomRightY)
        {
            int[] xCoordinates = {topLeftX, topRightX, bottomLeftX, bottomRightX};
            int[] yCoordinates = {topLeftY, topRightY, bottomLeftY, bottomRightY};

            this.minX = xCoordinates.Min();
            this.maxX = xCoordinates.Max();
            this.minY = yCoordinates.Min();
            this.maxY = yCoordinates.Max();
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

        public int GetBottomLeftX()
        {
            return this.bottomLeftX;
        }

        public int GetBottomLeftY()
        {
            return this.bottomLeftY;
        }
        public int GetBottomRightX()
        {
            return this.bottomRightX;
        }

        public int GetBottomRightY()
        {
            return this.bottomRightY;
        }

        public int GetTopLeftX()
        {
            return this.topLeftX;
        }

        public int GetTopLeftY()
        {
            return this.topLeftY;
        }

        public int GetTopRightX()
        {
            return this.topRightX;
        }

        public int GetTopRightY()
        {
            return this.topRightY;   
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
        public int GetMinX()
        {
            return this.minX;
        }
        public int GetMaxX()
        {
            return this.maxX;
        }
        public int GetMinY()
        {
            return this.minY;
        }
        public int GetMaxY()
        {
            return this.maxY;
        }
    }
}
