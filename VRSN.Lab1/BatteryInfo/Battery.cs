using System;

namespace VRSN.Lab1 
{
    public class Battery 
    {
        public int Capacity
        {
            get; set;
        }
        public BatteryTypes Type
        {
            get; set;
        }
        public bool IsRemovable
        {
            get; set;
        }
        public override string ToString() 
        {
            string statement;
            if (IsRemovable)
            {
                statement = "This is a removable block";
            }
            else
            {
                statement = "This is a monolithic block";
            }
            statement += String.Format(" with {0} battery and capacity of {1}",Type, Capacity);
            return statement;
        }
        public Battery(BatteryTypes type, int capacity, bool isRemovable)
        {
            Type = type;
            Capacity = capacity;
            IsRemovable = isRemovable;
        }
    }
}
