using System;

namespace VRSN.Lab1.PhoneJack {
    public class SamsungHeadset : IPlayback {
        public void Play(object data) {
            Console.WriteLine($"{nameof(SamsungHeadset)} sound");
        }
    }
}
