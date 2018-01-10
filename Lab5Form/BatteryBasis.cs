using System;
using System.Threading;
using System.Windows.Forms;

namespace Lab5Form {
    abstract class BatteryBasis {
        private int _chargeLevel;

        public int ChargeLevel {
            get { return _chargeLevel; }
            set {
                if (value > 100) {
                    _chargeLevel = 100;
                }
                else if (value < 0) {
                    _chargeLevel = 0;
                }
                else {
                    _chargeLevel = value;
                }
            }
        }

        public bool IsCharging { get; set; }

        public void BatteryUsing(ProgressBar bar) {
            while (true) {
                if (!IsCharging && ChargeLevel > 0) {
                    lock (this) {
                        ChargeLevel--;
                        Display(bar, ChargeLevel);
                        Thread.Sleep(1000);
                    }
                }
            }
        }

        public void BatteryCharging(ProgressBar bar) {
            while (true) {
                if (IsCharging && ChargeLevel < 100) {
                    lock (this) {
                        ChargeLevel += 3;
                        Display(bar, ChargeLevel);
                        Thread.Sleep(1000);
                    }
                }
            }
        }

        public void Display(ProgressBar bar, int chargeLvl) {
            if (bar.InvokeRequired) {
                bar.Invoke(new Action<ProgressBar, int>(Display), bar, chargeLvl);
            }
            else {
                bar.Value = chargeLvl;
            }
        }

        public abstract void StartThreads(ProgressBar bar);
    }
}
