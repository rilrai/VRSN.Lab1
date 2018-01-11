using System;

namespace Lab6Form {
    public class Call : IComparable {
        public string Name { get; set; }

        public bool IsIncoming;

        public DateTime CallStartTime;

        public DateTime CallEndTime;

        public Call(string name, bool incoming) {
            Name = name;
            IsIncoming = incoming;
            CallStartTime = DateTime.Now;
        }

        public void EndCall() {
            CallEndTime = DateTime.Now;
        }

        public int CompareTo(object obj) {            
            if (obj == null || (obj.GetType() == typeof(Call))) {
                return 1;
            }
            Call call = (Call) obj;
            return CallStartTime.CompareTo(call.CallStartTime);
        }
    }
}
