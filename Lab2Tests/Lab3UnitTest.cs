using System;
using System.Text;
using System.Threading;
using Lab3Form;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lab2Tests {
    [TestClass()]
    public class Lab3UnitTest {
        [TestMethod()]
        public void SmsRecieverEventTest() {
            SmsReceiver smsReceiver = new SmsReceiver();
            MobileLab3 mobile = new MobileLab3(smsReceiver);
            string built="";
            string sms = "Message received";

            mobile.Sms.SmsReceived += (string message) => {
                built = message;
            };
            mobile.ReceiveSms(sms);

            Assert.IsTrue(built.Equals(sms));
        }

        [TestMethod()]
        public void FormatTimeLastTest() {
            string sms = "Message received";
            string expected = $"{sms} [{DateTime.Now}] {Environment.NewLine}";
            string current = Lab3Form.MessageBox.FormatTimeLast(sms);

            Assert.IsTrue(expected.Equals(current));
        }

        [TestMethod()]
        public void FormatTimeFirstAndUpperTest() {
            string sms = "Message received";
            string expected = $"{sms.ToUpper()} [{DateTime.Now}] {Environment.NewLine}";
            string current = Lab3Form.MessageBox.FormatTimeLastAndUpper(sms);

            Assert.IsTrue(expected.Equals(current));
        }

    }
}
