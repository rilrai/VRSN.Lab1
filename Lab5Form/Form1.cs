using System;
using System.Threading;
using System.Windows.Forms;
using Timer = System.Threading.Timer;

namespace Lab5Form {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

            mobile.Sms.SmsReceived += OnSmsReceived;
            messageSender.StartSender();
            battery.StartThreads(progressBar1);
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

            richTextBox1.AppendText($"{message} {Environment.NewLine}");
        }

        // ----------------------------------------------------
        // Battery functionality
        // ----------------------------------------------------

        private Battery battery = new Battery();

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