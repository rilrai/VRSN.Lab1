using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3 {
    public class SmsReceiver {
        public delegate void SmsRecievedDelegate(string message);

        public event SmsRecievedDelegate SmsRecieved;

        private delegate string FormatDelegate(string text);

        private readonly FormatDelegate Formatter = new FormatDelegate(FormatWithTime);

        private void SmsRecievedEvent(string message) {
            SmsRecieved?.Invoke(message);
        }

        private static string FormatWithTime(string message) {
            return $"[{DateTime.Now}] {message}";
        }

        private void OnSmsRecieved(string message) {
            Invoke(new SmsReceiver.SmsRecievedDelegate(OnSmsRecieved), message);
            //return;

            string formattedMessage = Formatter($"{message}{Environment.NewLine}");
            
        }
    }
}
