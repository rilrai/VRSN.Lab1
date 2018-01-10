using System;
using System.Collections.Generic;
using System.Linq;
using Lab4Form;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lab2Tests {
    [TestClass]
    public class Lab4UnitTests {
        //
        // Fortat tests
        //

        [TestMethod]
        public void FormatTimeLastTest() {
            Message sms = new Message("Petya", DateTime.Now);
            string expected = $"{sms.Text} [{DateTime.Now}] {Environment.NewLine}";
            string current = MessageBoxLab4.FormatTimeLast(sms);

            Assert.IsTrue(expected.Equals(current));
        }

        [TestMethod]
        public void FormatTimeFirstAndUpperTest() {
            Message sms = new Message("Masha", DateTime.Now);
            string expected = $"[{DateTime.Now}] {sms.Text.ToUpper()} {Environment.NewLine}";
            string current = MessageBoxLab4.FormatTimeFirstAndUpper(sms);

            Assert.IsTrue(expected.Equals(current));
        }

        [TestMethod]
        public void FormatTimeFirstTest() {
            Message sms = new Message("Petya", DateTime.Now);
            string expected = $"[{DateTime.Now}] {sms.Text} {Environment.NewLine}";
            string current = MessageBoxLab4.FormatTimeFirst(sms);

            Assert.IsTrue(expected.Equals(current));
        }

        [TestMethod]
        public void FormatTimeLastAndUpperTest() {
            Message sms = new Message("Masha", DateTime.Now);
            string expected = $"{sms.Text.ToUpper()} [{DateTime.Now}] {Environment.NewLine}";
            string current = MessageBoxLab4.FormatTimeLastAndUpper(sms);

            Assert.IsTrue(expected.Equals(current));
        }

        //
        // Linq Tests
        //

        [TestMethod]
        public void DataSelectorTest1() {
            MobileLab4 mobile = new MobileLab4();
            Message message1 = new Message("Petya", DateTime.Now);
            Message message2 = new Message("Masha", DateTime.Now);
            mobile.Storage.Add(message1);
            mobile.Storage.Add(message2);

            List<Message> expected = new List<Message>();
            expected.Add(message1);

            List<Message> current = MessageBoxLab4.DataSelector(
                mobile, "Petya", new DateTime(2018, 1, 1), new DateTime(2018, 12, 31), "text", "AND").ToList();

            Assert.IsTrue(expected.ToString().Equals(current.ToString()));
        }

        public void DataSelectorTest2() {
            MobileLab4 mobile = new MobileLab4();
            Message message1 = new Message("Petya", DateTime.Now);
            Message message2 = new Message("Masha", DateTime.Now);
            mobile.Storage.Add(message1);
            mobile.Storage.Add(message2);

            List<Message> current = MessageBoxLab4.DataSelector(
                mobile, "Masha", new DateTime(2018, 1, 1), new DateTime(2018, 1, 2), "text", "AND").ToList();

            Assert.IsTrue(current.Count == 0);
        }

        public void DataSelectorTest3() {
            MobileLab4 mobile = new MobileLab4();
            Message message1 = new Message("Petya", DateTime.Now);
            Message message2 = new Message("Masha", DateTime.Now);
            mobile.Storage.Add(message1);
            mobile.Storage.Add(message2);

            List<Message> current = MessageBoxLab4.DataSelector(
                mobile, "Masha", new DateTime(2018, 1, 1), new DateTime(2018, 1, 2), "text", "OR").ToList();

            Assert.IsTrue(mobile.Storage.Messages.ToString().Equals(current.ToString()));
        }
    }
}