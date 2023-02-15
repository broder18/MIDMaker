using System;

namespace MIDMaker
{
    static class Defines
    {
        public const byte MaskBIOS = 0x01;
        public const byte MaskBVR = 0x02;
        public const byte MaskMFR = 0x04;
        public const ushort NumPackets = 16;
        public const ushort NumWords = 32;
        public const ushort LenWords = 2;
        public const ushort OffsetBIOSPacket = 9;
        public const ushort BufSize = NumPackets * NumWords * LenWords;

        public static int CalculateOffset(int len)
        {
            var offset = len / Defines.NumWords / Defines.LenWords;
            return offset * (Defines.NumWords * Defines.LenWords) + 1;
        }

        public static int CalculateBIOSOffset(int len)
        {
            var biosByteOffset = Defines.OffsetBIOSPacket * Defines.NumWords * Defines.LenWords;
            var offset = CalculateOffset(len);
            return offset < (biosByteOffset) ? biosByteOffset : offset;
        }
    }
}
