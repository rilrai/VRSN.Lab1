using System;
using System.Threading;
using System.Windows.Forms;
using Timer = System.Threading.Timer;

namespace Lab3Form {
    public partial class MessageBox : Form {
        public MessageBox() {
            InitializeComponent();
        }

        private delegate string FormatDelegate(string text);

        private FormatDelegate _formatter = FormatTimeFirst;

        private static string FormatTimeFirst(string message) {
            return $"[{DateTime.Now}] {message} {Environment.NewLine}";
        }

        private static string FormatTimeLast(string message) {
            return $"{message} [{DateTime.Now}] {Environment.NewLine}";
        }

        private static string FormatTimeFirstAndUpper(string message) {
            return $"[{DateTime.Now}] {message.ToUpper()} {Environment.NewLine}";
        }

        private static string FormatTimeLastAndUpper(string message) {
            return $"{message.ToUpper()} [{DateTime.Now}] {Environment.NewLine}";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            switch (comboBox1.SelectedIndex) {
                case (0):
                    _formatter = FormatTimeFirst;
                    break;
                case (1):
                    _formatter = FormatTimeLast;
                    break;
                case (2):
                    _formatter = FormatTimeFirstAndUpper;
                    break;
                case (3):
                    _formatter = FormatTimeLastAndUpper;
                    break;
            }

            SmsFormatter();
        }

        public static int ThreadCount = 1;

        private void SmsFormatter() {
            Mobile mobile = new Mobile(new SmsReceiver());

            mobile.Sms.SmsReceived += OnSmsReceived;

            int threadNumber = ThreadCount++;
            new Thread(start: () => {
                Timer timer = new Timer((sender) => {
                    mobile.ReceiveSms("pupipu from thread #" +
                                      threadNumber);
                }, null, 1000, 2000);
            }).Start();
        }

        private void OnSmsReceived(string message) {
            if (InvokeRequired) {
                Invoke(new SmsReceiver.SmsReceivedDelegate(OnSmsReceived), message);
                return;
            }

            string formattedMessage = _formatter(message);
            richTextBox1.AppendText(formattedMessage);
        }
    }
}