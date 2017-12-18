using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VRSN.Lab1 {
    class MonolithicBattery : Battery {
        public MonolithicBattery(BatteryTypes type, int volume) {
            Type = type;
            Volume = volume;
        }

        public override string ToString() {
            return "Monolithic Battery";
        }
    }
}
