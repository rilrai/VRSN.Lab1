using System;

namespace VRSN.Lab1.BatteryInfo {
    public class Battery {
        public int Capacity { get; set; }
        public BatteryTypes Type { get; set; }
        public bool IsRemovable { get; set; }

        public Battery(BatteryTypes type, int capacity, bool isRemovable) {
            Type = type;
            Capacity = capacity;
            IsRemovable = isRemovable;
        }

        public override string ToString() {
            string statement;
            if (IsRemovable)
            {
                statement = "This is a removable block";
            }
            else
            {
                statement = "This is a monolithic block";
            }
            statement += $" with {Type} battery and capacity of {Capacity}";
            return statement;
        }
    }
}