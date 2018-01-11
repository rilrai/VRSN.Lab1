using System.Threading;
using System.Windows.Forms;

namespace Lab5Form {
    public class BatteryWithThreads : BatteryBasis{
        public BatteryWithThreads() {
            ChargeLevel = 42;
            IsCharging = false;
        }

        public override void StartThreads(ProgressBar bar) {
            Thread useThread = new Thread(start: () => BatteryUsing(bar));
            useThread.Start();
            Thread chargeThread = new Thread(start: () => BatteryCharging(bar));
            chargeThread.Start();
        }
    }
}