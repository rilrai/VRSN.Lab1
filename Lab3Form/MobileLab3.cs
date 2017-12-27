namespace Lab3Form {
    public class MobileLab3 {
        public SmsReceiver Sms { get; set; }

        public MobileLab3(SmsReceiver smsReceiver) {
            Sms = smsReceiver;
        }

        public void ReceiveSms(string message) {
            Sms.SmsReceivedEvent(message);            
        }
    }
}