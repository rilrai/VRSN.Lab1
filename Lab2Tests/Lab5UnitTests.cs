using System.Threading;
using System.Windows.Forms;
using Lab5Form;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lab2Tests {
    [TestClass]
    public class Lab5UnitTests {
        [TestMethod]
        public void ChargeLevelTooHighTest() {
            MobileLab5 mob = new MobileLab5(new SmsReceiver());
            BatteryWithThreads battery = new BatteryWithThreads();
            battery.ChargeLevel = 100;
            battery.IsCharging = true;

            battery.StartThreads(new ProgressBar());
            Thread.Sleep(3500);

            Assert.IsTrue(battery.ChargeLevel == 100);
        }

        [TestMethod]
        public void ChargeLevelNegativeTest() {
            MobileLab5 mob = new MobileLab5(new SmsReceiver());
            BatteryWithTasks battery = new BatteryWithTasks();
            battery.ChargeLevel = 0;

            battery.StartThreads(new ProgressBar());
            Thread.Sleep(3500);

            Assert.IsTrue(battery.ChargeLevel == 0);
        }

        [TestMethod]
        public void BatteryUsingWithThreadsTest() {
            MobileLab5 mob = new MobileLab5(new SmsReceiver());
            BatteryWithThreads battery = new BatteryWithThreads();
            int startingChargeLevel = battery.ChargeLevel;

            battery.StartThreads(new ProgressBar());
            Thread.Sleep(3500);

            bool expectedTrue = startingChargeLevel > battery.ChargeLevel;
            expectedTrue = expectedTrue && (startingChargeLevel - 5) < battery.ChargeLevel;
            Assert.IsTrue(expectedTrue);
        }

        [TestMethod]
        public void BatteryUsingWithTasksTest() {
            MobileLab5 mob = new MobileLab5(new SmsReceiver());
            BatteryWithTasks battery = new BatteryWithTasks();
            int startingChargeLevel = battery.ChargeLevel;

            battery.StartThreads(new ProgressBar());
            Thread.Sleep(3500);

            bool expectedTrue = startingChargeLevel > battery.ChargeLevel;
            expectedTrue = expectedTrue && (startingChargeLevel - 5) < battery.ChargeLevel;
            Assert.IsTrue(expectedTrue);
        }
    }
}