using System;
using System.Collections.Generic;

namespace Lab6Form {
    public class CallGroup : IComparable {
        List<Call> calls = new List<Call>();

        private int _count;

        public int CallsCountInGroup => _count;

        public CallGroup(Call call) {
            calls.Add(call);
            _count = 1;
        }

        public void AddCall(Call call) {
            calls.Add(call);
            _count++;
        }

        public List<Call> GetCalls() {
            return calls;
        }

        public Call GetLastCall() {
            return calls[_count - 1];
        }

        public int CompareTo(object obj) {
            if (obj == null || (obj.GetType() == typeof(CallGroup))) {
                return 1;
            }
            CallGroup callGroup = (CallGroup) obj;           
            return GetLastCall().CallStartTime.CompareTo(callGroup.GetLastCall().CallStartTime);
        }
    }
}