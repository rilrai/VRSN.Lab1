using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Lab6Form;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lab2Tests {
    [TestClass]
    public class Lab6UnitTests {
        [TestMethod]
        public void CallsEqualityTest() {
            Call call1 = new Call("111", true);
            Call call2 = new Call("222", false);
            Call call3 = new Call("111", false);
            Call call4 = new Call("222", false);

            bool expectedTrue = !call1.Equals(call3);
            expectedTrue &= call2.Equals(call4);
            expectedTrue &= !call3.Equals(call4);
            Assert.IsTrue(expectedTrue);
        }

        [TestMethod]
        public void CallEqualsToObjTest() {
            Call call1 = new Call("111", true);
            Object call2 = new Call("111", true);

            Assert.IsTrue(call1.Equals(call2));
        }

        [TestMethod]
        public void CallEqualsToOtherTypeTest() {
            Call call = new Call("111", true);
            Contact contact = new Contact("111", "0987612345");

            Assert.IsFalse(call.Equals(contact));
        }

        [TestMethod]
        public void CallGroupComparisonTest() {
            MobileLab6 mob = new MobileLab6(new CallReceiver());

            Call call1 = new Call("111", true);
            Thread.Sleep(100);
            Call call2 = new Call("222", false);
            Thread.Sleep(100);
            Call call3 = new Call("111", false);

            mob.AddCalls(call3, call1);
            Thread.Sleep(100);
            mob.AddCalls(call2);

            Assert.IsTrue(mob.GetRelevantCalls()[2].Equals(call3));
        }
    }
}
