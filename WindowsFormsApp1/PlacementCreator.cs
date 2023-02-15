using System;

namespace MIDMaker
{
    internal class PlacementCreator
    {
        private byte[] _bufBios;
        private byte[] _bufBvr;
        private byte[] _bufMfr;

        internal PlacementCreator(ref byte[] bufBios, ref byte[] bufBvr, ref byte[] bufMfr)
        {
            _bufBios = bufBios;
            _bufBvr = bufBvr;
            _bufMfr = bufMfr;
        }

        public void Create(byte flags)
        {
            switch (flags)
            {
                default:
                    var placement = new BasePlacement();
                    placement.SaveFile();
                    break;

                case 0x01:
                    var obj = new BIOS_Placement();
                    obj.AddBIOSData(_bufBios);
                    obj.SaveFile();
                    break;

                case 0x02:
                    var obj2 = new BVR_Placement();
                    obj2.AddBVRData(_bufBvr);
                    obj2.SaveFile();
                    break;

                case 0x03:
                    var obj3 = new BiB_Placement();
                    obj3.AddBVRData(_bufBvr);
                    obj3.AddBIOSData(_bufBios);
                    obj3.SaveFile();
                    break;

                case 0x04:
                    var obj4 = new MFR_Placement();
                    obj4.AddMFRData(_bufMfr);
                    obj4.SaveFile();
                    break;

                case 0x05:
                    var obj5 = new BiM_Placement();
                    obj5.AddMFRData(_bufMfr);
                    obj5.AddBIOSData(_bufBios);
                    obj5.SaveFile();
                    break;

                case 0x06:
                    var obj6 = new BM_Placement();
                    obj6.AddMFRData(_bufMfr);
                    obj6.AddBVRData(_bufBvr);
                    obj6.SaveFile();
                    break;

                case 0x07:
                    var obj7 = new FullPlacement();
                    obj7.AddMFRData(_bufMfr);
                    obj7.AddBVRData(_bufBvr);
                    obj7.AddBIOSData(_bufBios);
                    obj7.SaveFile();
                    break;
            }
        }

    }
}
