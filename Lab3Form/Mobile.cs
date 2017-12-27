namespace Lab3Form {
    public class Mobile {
        public SmsReceiver Sms { get; set; }

        public Mobile(SmsReceiver smsReceiver) {
            Sms = smsReceiver;
        }

        public void ReceiveSms(string message) {
            Sms.SmsReceivedEvent(message);            
        }
    }
}