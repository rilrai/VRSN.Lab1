using System;

namespace Lab4Form {
    public class Message {
        private static int _messageCount = 0;

        public string Sender { get; set; }

        public DateTime Date { get; set; }

        public string Text { get; set; }

        public Message(string sender, DateTime time) {
            _messageCount++;
            Sender = sender;
            Date = time;
            Text = "Some random text #" + _messageCount;
        }
    }
}