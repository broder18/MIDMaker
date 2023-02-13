
namespace MIDMaker
{
    class FullPlacement : BasePlacement, IPostBIOS, IPostMFR, IPostBVR
    {
        private int _offsetBVR;
        private int _offsetBIOS;

        public void AddMFRData(byte[] data)
        {
            _offsetBVR = Defines.CalculateOffset(data.Length);
            PostData(data, 0);
        }

        public void AddBVRData(byte[] data)
        {
            _offsetBIOS = Defines.CalculateBIOSOffset(data.Length + _offsetBVR);
            PostData(data, _offsetBVR);
        }

        public void AddBIOSData(byte[] data)
        {
            PostData(data, _offsetBIOS);
        }
    }
}
