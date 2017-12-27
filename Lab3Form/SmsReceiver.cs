namespace Lab3Form {
    public class SmsReceiver {
        public delegate void SmsReceivedDelegate(string message);

        public event SmsReceivedDelegate SmsReceived;

        public void SmsReceivedEvent(string message) {
            SmsReceived?.Invoke(message);
        }
    }
}
