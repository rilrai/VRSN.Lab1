using System.Windows.Forms;

namespace Lab4Form {
    public class MobileLab4 {
        public SmsReceiver Sms { get; set; }

        public MessageStorage Storage { get; set; }

        public MobileLab4() {
            Storage = new MessageStorage();
        }

        public void ReceiveSms(Message message) {
            Storage.RaiseSmsAddedEvent(message);            
        }
    }
}