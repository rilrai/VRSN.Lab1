using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5Form {
    class BatteryWithTasks : BatteryBasis {
        public Task ChargeTask;
        public Task UseTask;

        public BatteryWithTasks() {
            ChargeLevel = 55;
            IsCharging = false;
        }

        public override void StartThreads(ProgressBar bar) {
            if (ChargeTask == null) {
                lock (this) {
                    if (ChargeTask == null) {
                        ChargeTask = new Task(() => BatteryCharging(bar));
                        ChargeTask.Start();
                    }
                }
            }
            if (UseTask == null) {
                lock (this) {
                    if (UseTask == null) {
                        UseTask = new Task(() => BatteryUsing(bar));
                        UseTask.Start();
                    }
                }
            }
        }
    }
}
