using System;
using System.Threading;
using System.Windows.Forms;
using Timer = System.Threading.Timer;

namespace Lab5Form {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

            mobile.Sms.SmsReceived += OnSmsReceived;

            battery.StartThreads(progressBar1);
        }

        static MobileLab5 mobile = new MobileLab5(new SmsReceiver());
        private bool _messageSenderOn;

        readonly Thread _messageSender = new Thread(start: () => {
            Timer timer = new Timer(send => { mobile.ReceiveSms("pupipu from thread"); }, null, 1000, 2000);
        });

        private void button2_Click(object sender, EventArgs e) {
            if (!_messageSenderOn) {
                _messageSenderOn = true;
                _messageSender.Start();
                button2.Text = "Stop sending messages";
            }
            else {
                _messageSenderOn = false;
                _messageSender.Interrupt();
                button2.Text = "Start sending messages";
            }
        }

        private void OnSmsReceived(string message) {
            if (InvokeRequired) {
                Invoke(new SmsReceiver.SmsReceivedDelegate(OnSmsReceived), message);
                return;
            }

            richTextBox1.AppendText($"{message} {Environment.NewLine}");
        }

        // ----------------------------------------------------
        // Battery functionality
        // ----------------------------------------------------

        private Battery battery = new Battery();

        delegate void SafeProgressBarDelegate();

        private void SafeBatteryDecrease() {
            if (progressBar1.InvokeRequired) {
                SafeProgressBarDelegate d = SafeBatteryDecrease;
                Invoke(d, new object[] {});
            }
            else {
                battery.ChargeLevel--;
                progressBar1.Value = battery.ChargeLevel;
            }
        }

        private void SafeBatteryIncrease() {
            if (progressBar1.InvokeRequired) {
                SafeProgressBarDelegate d = SafeBatteryIncrease;
                Invoke(d, new object[] {});
            }
            else {
                battery.ChargeLevel+=3;
                progressBar1.Value = battery.ChargeLevel;
            }
        }

        private void button3_Click(object sender, EventArgs e) {
            if (battery.IsCharging) {
                battery.IsCharging = false;
                button3.Text = "Stop charging";
            }
            else {
                battery.IsCharging = true;
                button3.Text = "Start charging";
            }
        }
    }
}