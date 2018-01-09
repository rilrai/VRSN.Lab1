namespace Lab4Form {
    public class SmsReceiver {
        public delegate void SmsReceivedDelegate(Message message);

        public event SmsReceivedDelegate SmsReceived;

        public void SmsReceivedEvent(Message message) {
            SmsReceived?.Invoke(message);
        }
    }
}
