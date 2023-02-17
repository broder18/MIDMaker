using System.Collections.Generic;
using System.Windows.Forms;

namespace MIDMaker
{
    class DatModule
    {
        public DatModule(string section)
        {
            Section = section;
        }

        public byte[] BufferBytes;
        public TextBox TextBox;
        public int PacketSize;
        public string Section;
        public string Path;
    }

    class ModuleManager
    {
        private readonly Dictionary<string, DatModule> _moduleMap;

        public ModuleManager()
        {
            _moduleMap = new Dictionary<string, DatModule>();
        }

        public void AddModule(string section)
        {
            _moduleMap.Add(section, new DatModule(section));
        }

        public void TextBox(string section, ref TextBox textBox, bool save)
        {
            if (save)
                _moduleMap[section].TextBox = textBox;
            else
                textBox = _moduleMap[section].TextBox;
        }

        public void PacketSize(string section, ref int packetSize, bool save)
        {
            if(save)
                _moduleMap[section].PacketSize = packetSize;
            else
                packetSize = _moduleMap[section].PacketSize;
        }

        public void Path(string section, ref string path, bool save)
        {
            if (save)
            {
                _moduleMap[section].Path = path;
                _moduleMap[section].TextBox.Text = path;
            }
            
            else
                path = _moduleMap[section].Path;
        }

        public void BufferBytes(string section, ref byte[] bufferBytes, bool save)
        {
            if (save)
                _moduleMap[section].BufferBytes = bufferBytes;
            else
                bufferBytes = _moduleMap[section].BufferBytes;
        }

       
    }
}
