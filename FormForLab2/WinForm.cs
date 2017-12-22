using System;
using System.Windows.Forms;
using LibraryLab2.PhoneJack;

namespace FormForLab2 {
    public partial class WinForm : Form {
        private IPlayback _selectedPlayback = new HtcHeadset();
        
        public WinForm() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            richTextBox1.Clear();
            if (_selectedPlayback != null) {
                richTextBox1.AppendText(_selectedPlayback.ToString());
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e) {
            _selectedPlayback = new XiaomiHeadset();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) {
            _selectedPlayback = new HtcHeadset();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) {
            _selectedPlayback = new SamsungHeadset();
        }
    }
}