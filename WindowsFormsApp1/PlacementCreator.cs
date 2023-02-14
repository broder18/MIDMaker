namespace MIDMaker
{
    internal class PlacementCreator
    {
        private BasePlacement placement;
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
                    placement = new BasePlacement();
                    Save();
                    break;

                case 0x01:
                    var obj = new BIOS_Placement();
                    obj.AddBIOSData(_bufBios);
                    placement = obj;
                    Save();
                    break;

                case 0x02:
                    var obj2 = new BVR_Placement();
                    obj2.AddBVRData(_bufBvr);
                    placement = obj2;
                    Save();
                    break;

                case 0x03:
                    var obj3 = new BiB_Placement();
                    obj3.AddBIOSData(_bufBios);
                    obj3.AddBVRData(_bufBvr);
                    placement = obj3;
                    Save();
                    break;

                case 0x04:
                    var obj4 = new MFR_Placement();
                    obj4.AddMFRData(_bufMfr);
                    placement = obj4;
                    Save();
                    break;

                case 0x05:
                    var obj5 = new BiM_Placement();
                    obj5.AddBIOSData(_bufBios);
                    obj5.AddMFRData(_bufMfr);
                    placement = obj5;
                    Save();
                    break;

                case 0x07:
                    var obj6 = new FullPlacement();
                    obj6.AddBIOSData(_bufBios);
                    obj6.AddBVRData(_bufBvr);
                    obj6.AddMFRData(_bufMfr);
                    placement = obj6;
                    Save();
                    break;
            }
        }

        private void Save()
        {
            placement.SaveFile();
            placement = null;
        }


    }
}
