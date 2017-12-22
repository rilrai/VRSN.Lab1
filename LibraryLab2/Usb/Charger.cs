using System;
using LibraryLab2.PhoneJack;

namespace LibraryLab2.Usb {
    public class Charger : IUsb {
        public void Use(object data) {
            Console.WriteLine(this.ToString());
        }

        public override string ToString() {
            return $"{nameof(Charger)} is charging your device";
        }
    }
}