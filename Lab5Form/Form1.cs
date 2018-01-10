using System;
using System.Threading;
using System.Windows.Forms;
using Timer = System.Threading.Timer;

namespace Lab5Form {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

            mobile.Sms.SmsReceived += OnSmsReceived;

            batteryUse = new Thread(start: () => {
                Timer timer = new Timer(sender => { SafeBatteryDecrease(); }, null, 1000, 1500);
            });
            batteryUse.Start();

            batteryCharge = new Thread(start: () => {
                Timer timer = new Timer(sender => { SafeBatteryIncrease(); }, null, 1000, 1500);
            });
        }

        static MobileLab5 mobile = new MobileLab5(new SmsReceiver());
        private bool _messageSenderOn;
        private bool _chargerOn = false;

        private Thread batteryUse;
        private Thread batteryCharge;

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
        delegate void SafeProgressBarDelegate();

        private void SafeBatteryDecrease() {
            if (progressBar1.InvokeRequired) {
                SafeProgressBarDelegate d = SafeBatteryDecrease;
                Invoke(d, new object[] {});
            }
            else {
                progressBar1.Value--;
            }
        }

        private void SafeBatteryIncrease() {
            if (progressBar1.InvokeRequired) {
                SafeProgressBarDelegate d = SafeBatteryDecrease;
                Invoke(d, new object[] { });
            }
            else {
                progressBar1.Value++;
            }
        }

        private void BatteryUseThreadControl() {
            ThreadSwitch threadSwitch = new ThreadSwitch(new ThreadController());
            threadSwitch.Controller.ThreadStatusChanged += OnChargerSwitch(_chargerOn);
        }


        private void OnChargerSwitch(bool flag) {
            if (InvokeRequired) {
                Invoke(new ThreadController.ThreadControllerDelegate(OnChargerSwitch), flag);
            }

            Thread.Sleep(Timeout.Infinite);
        }
        

        private void button3_Click(object sender, EventArgs e) {
            if (_chargerOn) {
                batteryUse.Start();
                batteryCharge.Interrupt();
                button2.Text = "Stop charging";
            }
            else {
                batteryUse.Interrupt();
                batteryCharge.Start();
                button2.Text = "Start charging";
            }
            
        }


    }
}