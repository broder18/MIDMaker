﻿using System;
using System.Drawing.Text;
using System.IO;

namespace MIDMaker
{
    interface IPostBVR
    {
        void AddBVRData(byte[] data);
    }

    interface IPostBIOS
    {
        void AddBIOSData(byte[] data);
    }

    interface IPostMFR
    {
        void AddMFRData(byte[] data);
    }

    class BasePlacement
    { 
        protected byte[] _buffer = new byte[Defines.BufSize];

        protected void PostData(byte[] data, int offset)
        {
            Array.Copy(data, 0, _buffer, offset, data.Length);
        }

        public virtual void SaveFile(string path)
        {
            using (var fstream = new FileStream(path, FileMode.Create))
            {
                fstream.Write(_buffer, 0, _buffer.Length);
            }
        }

    }

}