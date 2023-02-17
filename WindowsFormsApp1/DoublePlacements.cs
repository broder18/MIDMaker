namespace MIDMaker
{
    class BM_Placement : BasePlacement, IPostBVR, IPostMFR
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

    class BiB_Placement : BasePlacement, IPostBVR, IPostBIOS
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

    class BiM_Placement : BasePlacement, IPostBIOS, IPostMFR
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