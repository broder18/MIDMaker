using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        private const ushort NumPackets = 16;
        private const ushort NumWords = 32;
        private const ushort BufSize = NumPackets * NumWords * 2;
        private bool[] _checked = new bool[3];
        private int _noneEmptyPackets = 0;
        private int _packetsBios;
        private int _packetsBvr;
        private int _packetsMfr;
        private byte[] _bufBios;
        private byte[] _bufBvr;
        private byte[] _bufMfr;

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
        }

        #region CheckBox events
        private void checkBox_BIOS_CheckedChanged(object sender, EventArgs e)
        {
            _checked[0] = !_checked[0];
        }

        private void checkBox_BVR_CheckedChanged(object sender, EventArgs e)
        {
            _checked[1] = !_checked[1];
        }

        private void checkBox_MFR_CheckedChanged(object sender, EventArgs e)
        {
            _checked[2] = !_checked[2];
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
            var emptyPackets = NumPackets - _noneEmptyPackets;
            textBox_EmptyPackets.Text = emptyPackets < 0 ? @"0" : emptyPackets.ToString();
        }

        private void textBox_PacketCount_Transform()
        {
            textBox_PacketCount.Text = NoneEmptyPackets.ToString();
            textBox_PacketCount.BackColor = NoneEmptyPackets > NumPackets ? Color.Red : Color.Empty;
        }

        #endregion

        #region Button events

        private void button_Save_Transform()
        {
            button_Save.Enabled = NoneEmptyPackets <= NumPackets;
        }

        private void button_OpenBIOS_Click(object sender, EventArgs e)
        {
            ReadBuffer(textBox_BIOS, ref _bufBios, ref _packetsBios);
        }

        private void button_OpenBVR_Click(object sender, EventArgs e)
        {
            ReadBuffer(textBox_BVR, ref _bufBvr, ref _packetsBvr);
        }

        private void button_OpenMFR_Click(object sender, EventArgs e)
        {
            ReadBuffer(textBox_MFR, ref _bufMfr, ref _packetsMfr);
        }

        private void ReadBuffer(TextBox textBox, ref byte[] buf, ref int packetSize)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            var filename = openFileDialog.FileName;
            textBox.Text = filename;
            using (var fstream = File.OpenRead(filename))
            {
                buf = new byte[fstream.Length];
                var read = fstream.Read(buf, 0, buf.Length);
                NoneEmptyPackets = -packetSize;
                packetSize = read / NumWords / 2;
                NoneEmptyPackets = packetSize;
            }
        }

        #endregion

    }
}
