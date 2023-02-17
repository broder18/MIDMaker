using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MIDMaker
{
    public partial class MainForm : Form
    {
        private byte _checked = 0;
        private int _noneEmptyPackets = 0;

        private ModuleManager _moduleManager;
        private delegate void Action();
        private event Action OnSizePacketsChanged;
        private int NoneEmptyPackets
        {
            get => _noneEmptyPackets;
            set
            {
                if (value + _noneEmptyPackets == _noneEmptyPackets) return;
                _noneEmptyPackets += value;
                OnSizePacketsChanged?.Invoke();
            }
        }

        public MainForm()
        {
            InitializeComponent();
            OnSizePacketsChanged += textBox_PacketCount_Transform;
            OnSizePacketsChanged += button_Save_Transform;
            openFileDialog.Filter = @"dat files (*.dat)| *.dat";
            ReadINI();
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var iniManager = new INIManager("config.ini");
            iniManager.WriteString("main", "flags", _checked.ToString());
            WriteSection(iniManager, "bios");
            WriteSection(iniManager, "bvr");
            WriteSection(iniManager, "mfr");
        }

        #region CheckBox events

        private void CheckPackets(int packetsSize, bool checkBit)
        {
            if (checkBit)
                NoneEmptyPackets = packetsSize;
            else
                NoneEmptyPackets = -packetsSize;
        }

        private void checkBox_BIOS_CheckedChanged(object sender, EventArgs e)
        {
            _checked ^= Defines.MaskBIOS;
            var packetsSize = 0;
            _moduleManager.PacketSize("bios", ref packetsSize, false);
            CheckPackets(packetsSize, checkBox_BIOS.Checked);
        }

        private void checkBox_BVR_CheckedChanged(object sender, EventArgs e)
        {
            _checked ^= Defines.MaskBVR;
            var packetsSize = 0;
            _moduleManager.PacketSize("bvr", ref packetsSize, false);
            CheckPackets(packetsSize, checkBox_BVR.Checked);
        }

        private void checkBox_MFR_CheckedChanged(object sender, EventArgs e)
        {
            _checked ^= Defines.MaskMFR;
            var packetsSize = 0;
            _moduleManager.PacketSize("mfr", ref packetsSize, false);
            CheckPackets(packetsSize, checkBox_MFR.Checked);
        }

        #endregion

        #region TextBox events
        private void textBox_BIOS_TextChanged(object sender, EventArgs e)
        {
            checkBox_BIOS.Enabled = this.textBox_BIOS.Text.Length > 0;
        }

        private void textBox_BVR_TextChanged(object sender, EventArgs e)
        {
            checkBox_BVR.Enabled = this.textBox_BVR.Text.Length > 0;
        }

        private void textBox_MFR_TextChanged(object sender, EventArgs e)
        {
            checkBox_MFR.Enabled = this.textBox_MFR.Text.Length > 0;
        }

        private void textBox_PacketCount_TextChanged(object sender, EventArgs e)
        {
            var emptyPackets = Defines.NumPackets - _noneEmptyPackets;
            textBox_EmptyPackets.Text = emptyPackets < 0 ? @"0" : emptyPackets.ToString();
        }

        private void textBox_PacketCount_Transform()
        {
            textBox_PacketCount.Text = NoneEmptyPackets.ToString();
            textBox_PacketCount.BackColor = NoneEmptyPackets > Defines.NumPackets ? Color.Red : Color.Empty;
        }

        #endregion

        #region FileDialog

        private void SavePathDialog(string section)
        {
            var path = openFileDialog.FileName;
            _moduleManager.Path(section, ref path, true);
        }

        private bool CheckFileDialog()
        {
            return openFileDialog.ShowDialog() != DialogResult.Cancel;
        }

        private void ReadFileDialog(string section)
        {
            var filename = openFileDialog.FileName;
            TextBox textBox = null;
            _moduleManager.TextBox(section, ref textBox, false);
            textBox.Text = filename;
        }

        #endregion

        #region Button events

        private void button_Save_Transform()
        {
            button_Save.Enabled = NoneEmptyPackets <= Defines.NumPackets;
        }

        private void button_OpenBIOS_Click(object sender, EventArgs e)
        {
            if(!CheckFileDialog()) return;
            SavePathDialog("bios");
            ReadFileDialog("bios");
            ReadBuffer("bios");
        }

        private void button_OpenBVR_Click(object sender, EventArgs e)
        {
            if (!CheckFileDialog()) return;
            SavePathDialog("bvr");
            ReadFileDialog("bvr");
            ReadBuffer("bvr");
        }

        private void button_OpenMFR_Click(object sender, EventArgs e)
        {
            if (!CheckFileDialog()) return;
            SavePathDialog("mfr");
            ReadFileDialog("mfr");
            ReadBuffer("mfr");
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            byte[] bytesBios = { },
                bytesBvr = { },
                bytesMfr = { };

            if (_checked % 2 == 1)
                _moduleManager.BufferBytes("bios", ref bytesBios, false);

            if ((_checked >> 1) % 2 == 1)
                _moduleManager.BufferBytes("bvr", ref bytesBvr, false);

            if ((_checked >> 2) % 2 == 1)
                _moduleManager.BufferBytes("mfr", ref bytesMfr, false);

            var creator = new PlacementCreator(bytesBios, bytesBvr, bytesMfr);
            creator.Create(_checked);
        }

        #endregion

        #region ReadingData
        private void ReadBuffer(string section)
        {
            var read = ReadBytes(section);
            ChangeNoneEmptyPackets(section, read);
        }

        private void ChangeNoneEmptyPackets(string section, int read)
        {
            var packetsSize = 0;
            _moduleManager.PacketSize(section, ref packetsSize, false);
            NoneEmptyPackets = -packetsSize;
            var fractionPacket = read % (Defines.NumWords * Defines.LenWords);
            packetsSize = read / Defines.NumWords / Defines.LenWords;
            if (fractionPacket != 0)
                packetsSize++;
            _moduleManager.PacketSize(section, ref packetsSize, true);
        }

        private int ReadBytes(string section)
        {
            string filename = null;
            _moduleManager.Path(section, ref filename, false);
            using (var fstream = File.OpenRead(filename))
            {
                var bytesArray = new byte[fstream.Length];
                var read = fstream.Read(bytesArray, 0, bytesArray.Length);
                _moduleManager.BufferBytes(section, ref bytesArray, true);
                return read;
            }
        }

        #endregion

        #region INI

        private void WriteSection(INIManager iniManager, string section)
        {
            var path ="";
            _moduleManager.Path(section, ref path, false);
            iniManager.WriteString(section, "path", path);
            var packetsSize = 0;
            _moduleManager.PacketSize(section, ref packetsSize, false);
            iniManager.WriteString(section, "packetsSize", packetsSize.ToString());
        }

        private void ReadINI()
        {
            var iniManager = new INIManager("config.ini");
            _moduleManager = new ModuleManager();
            AddModuleParams("bios", iniManager, textBox_BIOS);
            AddModuleParams("bvr", iniManager, textBox_BVR);
            AddModuleParams("mfr", iniManager, textBox_MFR);
            TransformCheckBox(iniManager);
        }

        private void TransformCheckBox(INIManager iniManager)
        {
            var flags = Convert.ToByte(iniManager.ReadString("main", "flags"));
            checkBox_BIOS.Checked = Convert.ToBoolean(flags % 2);
            checkBox_BVR.Checked = Convert.ToBoolean(flags >> 1 % 2);
            checkBox_MFR.Checked = Convert.ToBoolean(flags >> 2 % 2);
        }

        private void AddModuleParams(string section, INIManager iniManager, TextBox textBox)
        {
            _moduleManager.AddModule(section);
            _moduleManager.TextBox(section, ref textBox, true);
            AddPath(section, iniManager);
            ReadBuffer(section);
        }

        private void AddPath(string section, INIManager iniManager)
        {
            var filename = iniManager.ReadString(section, "path");
            if (filename == string.Empty) return;
            _moduleManager.Path(section, ref filename, true);
        }

        #endregion

    }
}
