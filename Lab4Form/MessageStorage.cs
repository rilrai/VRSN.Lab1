using System;
using System.Collections.Generic;

namespace Lab4Form {
    public class MessageStorage {
        private List<Message> _messages = new List<Message>();
        public List<Message> Messages => _messages;

        private List<string> _senders = new List<string>();
        public List<string> Senders => _senders;

        public MessageStorage() {
            _senders.Add("Petya");
            _senders.Add("Vasya");
            _senders.Add("Masha");
            _senders.Add("Sasha");
        }

        public void Fill(int num) {
            DateTime[] dates = new[] {
                new DateTime(2018, 1, 1),
                new DateTime(2018, 1, 2),
                new DateTime(2018, 1, 3),
                new DateTime(2018, 1, 4),
                new DateTime(2018, 1, 5)
            };
            Random random = new Random();
            foreach (string sender in _senders) {
                for (int i = 0; i < num; i++) {
                    _messages.Add(new Message(sender, dates[random.Next(dates.Length)]));
                }
            }
        }

        public void Add(Message message) {
            _messages.Add(message);
            RaiseSmsAddedEvent(message);
        }

        public void Remove(Message message) {
            _messages.Remove(message);
            RaiseSmsRemovedEvent(message);
        }

        public delegate void SmsAddedDelegate(Message message);

        public delegate void SmsRemovedDelegate(Message message);

        public event SmsAddedDelegate SmsAdded;
        public event SmsRemovedDelegate SmsRemoved;

        public void RaiseSmsAddedEvent(Message message) {
            SmsAdded?.Invoke(message);
        }

        public void RaiseSmsRemovedEvent(Message message) {
            SmsRemoved?.Invoke(message);
        }
    }
}