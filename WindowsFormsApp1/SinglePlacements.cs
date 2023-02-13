using System;

namespace MIDMaker
{
    class MFR_Placement : BasePlacement
    {
        public void AddMFRData(byte[] data)
        {
            PostData(data, 0);
        }
    }

    class BVR_Placement : BasePlacement
    {
        public void AddBVRData(byte[] data)
        {
            PostData(data, 0);
        }
    }

    class BIOS_Placement : BasePlacement
    {
        const int Offset = Defines.OffsetBIOSPacket * Defines.NumWords * Defines.LenWords;
        public void AddBIOSData(byte[] data)
        {
            PostData(data, 0);
        }
    }
}
