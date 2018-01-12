using System;

namespace Lab6Form {
    public class Call {
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

        public override bool Equals(object obj) {
            if (obj == null || (obj.GetType() == typeof(Call))) {
                return false;
            }
            Call call = (Call)obj;
            bool isEqual = Name == call.Name;
            isEqual &= IsIncoming == call.IsIncoming;

            return isEqual;
        }
    }
}
