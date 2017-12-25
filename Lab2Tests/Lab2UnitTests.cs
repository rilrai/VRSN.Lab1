using System.IO;
using Lab2;
using LibraryLab2;
using LibraryLab2.PhoneJack;
using LibraryLab2.Usb;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lab2Tests {
    [TestClass()]
    public class Lab2UnitTests {
        [TestMethod()]
        public void HeadsetTest() {
            IOutput output = new ConsoleOutput();
            IUsb usb = new Charger();
            IPlayback headset = new HtcHeadset(output);

            Mobile mobile = new Mobile(headset,usb);
            
            try {
                mobile.PlaybackComponent.Play(output);
            }
            catch (IOException) {
                Assert.IsTrue(true);
            }

            mobile.PlaybackComponent = new SamsungHeadset();

            string headsetOutput = mobile.PlaybackComponent.ToString();
            Assert.IsTrue(headsetOutput.Contains("SamsungHeadset"));
            Assert.IsTrue(headsetOutput.Contains("sound"));
        }
    }
}
