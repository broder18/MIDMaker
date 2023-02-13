using System.ComponentModel;
using System.Security.Cryptography;

namespace MIDMaker
{
    class BM : BasePlacement, IPostBVR, IPostMFR
    {
        private int _offsetBVR;
        public void AddMFRData(byte[] data)
        {
            _offsetBVR = Defines.CalculateOffset(data.Length);
            PostData(data, 0);
        }

        public void AddBVRData(byte[] data)
        {
            PostData(data, _offsetBVR);
        }
    }

    class BiB : BasePlacement, IPostBVR, IPostBIOS
    {
        private int _offsetBIOS;
        public void AddBVRData(byte[] data)
        {
            _offsetBIOS = Defines.CalculateBIOSOffset(data.Length);
            PostData(data, 0);
        }

        public void AddBIOSData(byte[] data)
        {
            PostData(data, _offsetBIOS);
        }
    }

    class BiM : BasePlacement, IPostBIOS, IPostMFR
    {
        private int _offsetBIOS;

        public void AddMFRData(byte[] data)
        {
            _offsetBIOS = Defines.CalculateBIOSOffset(data.Length);
            PostData(data, 0);
        }

        public void AddBIOSData(byte[] data)
        {
            PostData(data, _offsetBIOS);
        }
    }
}