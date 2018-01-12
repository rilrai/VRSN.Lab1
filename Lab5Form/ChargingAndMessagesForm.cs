using System;
using System.Threading;
using System.Windows.Forms;
using Timer = System.Threading.Timer;

namespace Lab5Form {
    public partial class ChargingAndMessagesForm : Form {
        public ChargingAndMessagesForm() {
            InitializeComponent();

            mobile.Sms.SmsReceived += OnSmsReceived;
            messageSender.StartSender();
        }

        // -----------------------------------------------------
        // Message sending
        // -----------------------------------------------------

        static MobileLab5 mobile = new MobileLab5(new SmsReceiver());

        private MessageSender messageSender = new MessageSender(mobile);

        private void button2_Click(object sender, EventArgs e) {
            if (!messageSender.MessageSenderOn) {
                messageSender.MessageSenderOn = true;
                button2.Text = "Stop sending messages";
            }
            else {
                messageSender.MessageSenderOn = false;
                button2.Text = "Start sending messages";
            }
        }

        private void OnSmsReceived(string message) {
            if (InvokeRequired) {
                Invoke(new SmsReceiver.SmsReceivedDelegate(OnSmsReceived), message);
                return;
            }

            richTextBox1?.AppendText($"{message} {Environment.NewLine}");
        }

        protected override void OnFormClosing(FormClosingEventArgs e) {
            messageSender.MessageSenderOn = false;
        }

        // ----------------------------------------------------
        // Battery functionality
        // ----------------------------------------------------

        private BatteryWithThreads _batteryWithThreads = new BatteryWithThreads();
        private BatteryWithTasks _batteryWithTasks = new BatteryWithTasks();
        private bool _useThreads;

        private void button3_Click(object sender, EventArgs e) {
            if (_useThreads) {
                if (_batteryWithThreads.IsCharging) {
                    _batteryWithThreads.IsCharging = false;
                    button3.Text = "Start charging";
                }
                else {
                    _batteryWithThreads.IsCharging = true;
                    button3.Text = "Stop charging";
                }
            }
            else {
                if (_batteryWithTasks.IsCharging) {
                    _batteryWithTasks.IsCharging = false;

                    button3.Text = "Start charging";
                }
                else {
                    _batteryWithTasks.IsCharging = true;
                    button3.Text = "Stop charging";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            _batteryWithThreads.StartThreads(progressBar1);
            _useThreads = true;
            button1.Enabled = false;
            button4.Enabled = false;
            button3.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e) {
            _batteryWithTasks.StartThreads(progressBar1);
            _useThreads = false;
            button1.Enabled = false;
            button4.Enabled = false;
            button3.Enabled = true;
        }
    }
}