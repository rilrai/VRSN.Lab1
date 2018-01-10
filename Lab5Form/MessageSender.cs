using System.Threading;

namespace Lab5Form {
    class MessageSender {
        public bool MessageSenderOn { get; set; }

        private static MobileLab5 _mob;

        public MessageSender(MobileLab5 mob) {
            _mob = mob;
        }

        public void StartSender() {
            Thread messageSender = new Thread(start: () => SenderThreadMethod(_mob));
            messageSender.Start();
        }

        public void SenderThreadMethod(MobileLab5 mob) {
            while (true) {
                if (MessageSenderOn) {
                    mob.ReceiveSms("pupipu from thread");
                    Thread.Sleep(1500);
                }
            }
        }
    }
}