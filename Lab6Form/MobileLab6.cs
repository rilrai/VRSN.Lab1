using System.Collections.Generic;

namespace Lab6Form {
    public class MobileLab6 {
        public CallReceiver Call { get; set; }

        public List<Contact> ContactList = new List<Contact>();

        List<Call> CallHistory = new List<Call>();

        public MobileLab6(CallReceiver callReceiver) {
            Call = callReceiver;
        }

        public void ReceiveCall(Call call) {
            Call.CallReceivedEvent(call);
        }

        public void AddCalls(params Call[] calls) {
            foreach (var call in calls) {
                CallHistory.Add(call);
            }
        }

        public void ClearCallHistory() {
            CallHistory.Clear();
        }

        public List<Call> GetCallHistory() {
            CallHistory.Sort();
            return CallHistory;
        }
    }
}