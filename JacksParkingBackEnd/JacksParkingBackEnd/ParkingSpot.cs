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
        private int slope;
        private byte[] red;
        private byte[] green;
        private byte[] blue;
        Bitmap lot;

        public ParkingSpot(int topX, int topY, int bottomX, int bottomY)
        {
            this.topX = topX;
            this.bottomY = bottomY;
            this.topY = topY;
            this.bottomX = bottomX;
            this.length = (int)Math.Sqrt(Math.Pow((double)(topX - bottomX), 2) + Math.Pow((double)(topY - bottomY), 2)); //distance formula
            this.slope = (topY - bottomY) / (topX - bottomX);
            this.red = Bitmapping.getR();
            this.blue = Bitmapping.getB();
            this.green = Bitmapping.getG();
        }

        public void requestBitmap()
        {
            this.lot = 
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

        public byte[] getRed()
        {
            return this.red;
        }

        public byte[] getBlue()
        {
            return this.blue;
        }
        public byte[] getGreen()
        {
            return this.green;
        }

    }
}
