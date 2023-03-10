using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Text;

namespace MIDMaker
{
    internal class INIManager
    {
        private const int Size = 1024;
        private readonly string _path;

        public bool IsExists
        {
            get;
        }

        public INIManager(string aPath)
        {
            _path = Path.ChangeExtension(Application.ExecutablePath, ".ini");
            IsExists = File.Exists(_path);
        }

        public string ReadString(string aSection, string aKey)
        {
            var buffer = new StringBuilder(Size);
            GetPrivateProfileString(aSection, aKey, null, buffer, Size, _path);
            return buffer.ToString();
        }

        public void WriteString(string aSection, string aKey, string aValue)
        {
            WritePrivateProfileString(aSection, aKey, aValue, _path);
        }

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder buffer, int size, string path);

        
        [DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
        private static extern int WritePrivateProfileString(string section, string key, string str, string path);
    }
}

