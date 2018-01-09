using System.Windows.Forms;

namespace Lab4Form {
    public class MobileLab4 {
        public MessageStorage Storage { get; set; }

        public MobileLab4() {
            Storage = new MessageStorage();
        }
    }
}