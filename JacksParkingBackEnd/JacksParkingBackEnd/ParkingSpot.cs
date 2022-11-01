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
        private double b;
        private double[] red;
        private double[] green;
        private double[] blue;
        private bool topLeft;


        public ParkingSpot(int topX, int topY, int bottomX, int bottomY, bool topLeft)
        {
            this.topX = topX;
            this.bottomY = bottomY;
            this.topY = topY;
            this.bottomX = bottomX;
            xRange = Math.Abs(topX - bottomX);
            this.length = (int)Math.Sqrt(Math.Pow((double)(topX - bottomX), 2) + Math.Pow((double)(topY - bottomY), 2)); //distance formula
            this.slope = (topY - bottomY) / (topX - bottomX);
            this.b = (this.topY) - (this.slope * this.topX);
            this.topLeft = topLeft;
        }

        public bool getTopLeft()
        {
            return this.topLeft;
        }

        public int getXRange()
        {
            return this.xRange;
        }
        public void setR(double[] red)
        {
            this.red = red;
        }

        public void setG(double[] green)
        {
            this.green = green;
        }

        public void setB(double[] blue)
        {
            this.blue = blue;
        }

        public int getBottomX()
        {
            return this.bottomX;
        }

        public int getBottomY()
        {
            return this.bottomY;
        }

        public int getTopX()
        {
            return this.topX;
        }

        public int getTopY()
        {
            return this.topY;
        }

        public int getLength()
        {
            return this.length;
        }

        public double[] getRed()
        {
            return this.red;
        }

        public double[] getBlue()
        {
            return this.blue;
        }
        public double[] getGreen()
        {
            return this.green;
        }

        public double getSlope()
        {
            return this.slope;
        }

        public double getB()
        {
            return this.b;
        }

    }
}
