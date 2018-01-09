namespace Lab5Form {
    public class MobileLab5 {
        public SmsReceiver Sms { get; set; }

        public MobileLab5(SmsReceiver smsReceiver) {
            Sms = smsReceiver;
        }

        public void ReceiveSms(string message) {
            Sms.SmsReceivedEvent(message);            
        }
    }
}