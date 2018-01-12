using System.Collections.Generic;
using System.Linq.Expressions;

namespace Lab6Form {
    public class MobileLab6 {
        public CallReceiver Receiver { get; set; }

        public List<Contact> ContactList = new List<Contact>();

        List<CallGroup> CallHistory = new List<CallGroup>();

        public MobileLab6(CallReceiver receiverReceiver) {
            Receiver = receiverReceiver;
        }

        public void ReceiveCall(Call call) {
            Receiver.CallReceivedEvent(call);
        }

        public void AddCalls(params Call[] calls) {
            foreach (var call in calls) {
                if (CallHistory.Count != 0) {
                    if (call.Equals(GetLastGroup().GetLastCall())) {
                        GetLastGroup().AddCall(call);
                        return;
                    }
                }
                CallHistory.Add(new CallGroup(call));
            }
            CallHistory.Sort();
        }

        public CallGroup GetLastGroup() {
            return CallHistory[CallHistory.Count - 1];
        }

        public void ClearCallHistory() {
            CallHistory.Clear();
        }

        public Call[] GetRelevantCalls() {
            Call[] calls = new Call[CallHistory.Count];
            for (int i = 0; i < CallHistory.Count; i++) {
                calls[i] = CallHistory[i].GetLastCall();
            }
            return calls;
        }
    }
}