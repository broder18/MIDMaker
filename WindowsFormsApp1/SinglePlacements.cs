namespace MIDMaker
{
    internal class MFR_Placement : BasePlacement
    {
        public void AddMFRData(byte[] data)
        {
            PostData(data, 0);
        }
    }

    internal class BVR_Placement : BasePlacement
    {
        public void AddBVRData(byte[] data)
        {
            PostData(data, 0);
        }
    }

    internal class BIOS_Placement : BasePlacement
    {
        private const int DefaultOffset = Defines.OffsetBIOSPacket * Defines.NumWords * Defines.LenWords;

        public void AddBIOSData(byte[] data)
        {
            PostData(data, DefaultOffset);
        }
    }
}
