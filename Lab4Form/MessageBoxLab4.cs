using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Timer = System.Threading.Timer;

namespace Lab4Form {
    public partial class MessageBoxLab4 : Form {
        public MessageBoxLab4() {
            InitializeComponent();
            for (int i = 1; i <= 31; i++) {
                this.comboBox3.Items.Add(new DateTime(2018, 1, i));
                this.comboBox4.Items.Add(new DateTime(2018, 1, i));
            }
            comboBox1.SelectedIndex = 1;
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = comboBox4.Items.Count - 1;
        }

        private delegate string FormatDelegate(Message message);

        private FormatDelegate _formatter = FormatTimeFirst;

        MobileLab4 mobile = new MobileLab4();

        public static string FormatTimeFirst(Message message) {
            return $"[{message.Date}] {message.Text} {Environment.NewLine}";
        }

        public static string FormatTimeLast(Message message) {
            return $"{message.Text} [{message.Date}] {Environment.NewLine}";
        }

        public static string FormatTimeFirstAndUpper(Message message) {
            return $"[{message.Date}] {message.Text.ToUpper()} {Environment.NewLine}";
        }

        public static string FormatTimeLastAndUpper(Message message) {
            return $"{message.Text.ToUpper()} [{message.Date}] {Environment.NewLine}";
        }

        public static int ThreadCount = 1;

        private void SmsFormatter() {
            Random random = new Random();
            mobile.Storage.SmsAdded += OnSmsReceived;

            Thread currentThread = new Thread(start: () => {
                Timer timer =
                    new Timer(
                        (sender) => {
                            mobile.Storage.Add(new Message(mobile.Storage.Senders[random.Next(4)], DateTime.Now));
                        }, null,
                        1000,
                        2000);
            });
            currentThread.Start();
        }

        private void OnSmsReceived(Message message) {
            if (InvokeRequired) {
                Invoke(new SmsReceiver.SmsReceivedDelegate(OnSmsReceived), message);
                return;
            }

            if (message.Sender == comboBox1.SelectedItem.ToString()) {
                string formattedMessage = _formatter(message);
                richTextBox1.AppendText(formattedMessage);
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            richTextBox1.Text = "";
            switch (comboBox2.SelectedIndex) {
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

            string transmitter = comboBox1.SelectedItem.ToString();
            DateTime fromDate = (DateTime) comboBox3.SelectedItem;
            DateTime toDate = (DateTime) comboBox4.SelectedItem;
            string search = textBox3.Text;
            IEnumerable<Message> displayMessages;

            if (radioButton2.Checked) {
                displayMessages = DataSelector(mobile, transmitter, fromDate, toDate, search, "AND");
            }
            else {
                displayMessages = DataSelector(mobile, transmitter, fromDate, toDate, search, "OR");
            }

            foreach (var message in displayMessages) {
                string formattedMessage = _formatter(message);
                richTextBox1.AppendText(formattedMessage);
            }

            SmsFormatter();
        }

        private void button2_Click(object sender, EventArgs e) {
            mobile.Storage.Fill(10);
        }

        public static IEnumerable<Message> DataSelector(MobileLab4 mob, String transmitter, DateTime fromDate, DateTime toDate, string search,
            string condition) {
            IEnumerable<Message> displayMessages = new List<Message>();
            switch (condition) {
                case "AND":
                    displayMessages = from s in mob.Storage.Messages
                        where s.Sender == transmitter
                              && s.Date >= fromDate
                              && s.Date <= toDate
                              && s.Text.Contains(search)
                        select s
                        ;
                    break;
                case "OR":
                    displayMessages = from s in mob.Storage.Messages
                        where s.Sender == transmitter
                              || s.Date >= fromDate
                              || s.Date <= toDate
                              || s.Text.Contains(search)
                        select s
                        ;
                    break;
            }

            return displayMessages;
        }
    }
}