namespace MIDMaker
{
    static class Defines
    {
        public const ushort NumPackets = 16;
        public const ushort NumWords = 32;
        public const ushort LenWords = 2;
        public const ushort OffsetBIOSPacket = 9;
        public const ushort BufSize = NumPackets * NumWords * LenWords;

        public static int CalculateOffset(int len)
        {
            var offset = len / Defines.NumWords / Defines.LenWords / Defines.NumWords;
            return offset;
        }

        public static int CalculateBIOSOffset(int len)
        {
            var offset = CalculateOffset(len);
            return offset < 9 ? 9 : offset;
        }
    }
}
