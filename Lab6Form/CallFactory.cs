using System;
using System.Threading;

namespace Lab6Form {
    class CallFactory {
        public bool CallSenderOn { get; set; }

        Random _rnd = new Random();

        private static MobileLab6 _mob;

        public CallFactory(MobileLab6 mob) {
            _mob = mob;
        }

        private Thread callSender;

        public void StartSender() {
            callSender = new Thread(start: () => SenderThreadMethod(_mob));
            callSender.Start();
        }

        public bool IsCallSenderAlive() {
            if (callSender == null) {
                return false;
            }
            if (callSender.IsAlive) {
                return true;
            }
            return false;
        }

        public void SenderThreadMethod(MobileLab6 mob) {
            while (true) {
                if (CallSenderOn) {
                    string name = _mob.ContactList[_rnd.Next(_mob.ContactList.Count)].Name;
                    bool isIncoming = _rnd.Next(100) <= 20 ? true : false;
                    mob.ReceiveCall(new Call(name, isIncoming));
                    int sleepTime = (_rnd.Next(5)+1)*1000;
                    Thread.Sleep(sleepTime);
                }
            }
        }
    }
}