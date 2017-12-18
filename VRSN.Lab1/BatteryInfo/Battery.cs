using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VRSN.Lab1 {
    public abstract class Battery {
        public int Volume {
            get; set;
        }
        public BatteryTypes Type {
            get; set;
        }
    }
}
