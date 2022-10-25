

namespace JacksParkingBackEnd
{
    public interface ParkingSpotInterface
    {
        public int getTopX();
        public int getTopY();
        public int getBottomX();
        public int getBottomY();
        public int getLength();
        public byte[] getRed();
        public byte[] getBlue();
        public byte[] getGreen();

    }
}
