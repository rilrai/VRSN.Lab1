using System;
using System.Windows.Forms;
using LibraryLab2.PhoneJack;
using LibraryLab2.Usb;

namespace FormForLab2 {
    public partial class WinForm : Form {
        private IPlayback _selectedPlayback = new HtcHeadset();
        private IUsb _selectedUsb = new Charger();

        public WinForm() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            richTextBox1.Clear();
            richTextBox1.AppendText(_selectedPlayback.ToString());
            richTextBox1.AppendText("\n"+_selectedUsb.ToString());
        }

        private void XiaomiButton_CheckedChanged(object sender, EventArgs e) {
            _selectedPlayback = new XiaomiHeadset();
        }

        private void HtcButton_CheckedChanged(object sender, EventArgs e) {
            _selectedPlayback = new HtcHeadset();
        }

        private void SamsungButton_CheckedChanged(object sender, EventArgs e) {
            _selectedPlayback = new SamsungHeadset();
        }

        private void ChargerButton_CheckedChanged(object sender, EventArgs e) {
            _selectedUsb = new Charger();
        }

        private void DynamicsButton_CheckedChanged(object sender, EventArgs e) {
            _selectedUsb = new Dynamics();
        }

        private void GameConsoleButton_CheckedChanged(object sender, EventArgs e) {
            _selectedUsb = new GameConsole();
        }
    }
}