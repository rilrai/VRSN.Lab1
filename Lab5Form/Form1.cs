using System;
using System.Threading;
using System.Windows.Forms;
using Timer = System.Threading.Timer;

namespace Lab5Form {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

            mobile.Sms.SmsReceived += OnSmsReceived;

            Thread batteryUse = new Thread(start: () => {
                Timer timer = new Timer(sender => { SafeProgressChange(); }, null, 1000, 2000);
            });
            batteryUse.Start();
        }

        static MobileLab5 mobile = new MobileLab5(new SmsReceiver());
        private bool _messageSenderOn;
        private bool _chargerOn = false;

        Thread messageSender = new Thread(start: () => {
            Timer timer = new Timer(send => { mobile.ReceiveSms("pupipu from thread"); }, null, 1000, 2000);
        });

        private void button2_Click(object sender, EventArgs e) {
            if (!_messageSenderOn) {
                _messageSenderOn = true;
                messageSender.Start();
                button2.Text = "Stop sending messages";
            }
            else {
                _messageSenderOn = false;
                messageSender.Abort();
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
        delegate void SafeProgressBarDelegate();

        private void SafeProgressChange() {
            if (progressBar1.InvokeRequired) {
                SafeProgressBarDelegate d = SafeProgressChange;
                Invoke(d, new object[] {});
            }
            else {
                progressBar1.Value--;
            }
        }

        private void button3_Click(object sender, EventArgs e) {
            button2.Text = _chargerOn ? "Stop charging" : "Start charging";
        }
    }
}