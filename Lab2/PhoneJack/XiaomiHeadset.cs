using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VRSN.Lab1.PhoneJack {
    class XiaomiHeadset : IPlayback {
        public void Play(object data) {
            Console.WriteLine($"{nameof(XiaomiHeadset)} sound");
        }
    }
}
