using System;

namespace LibraryLab2.Usb {
    public class Dynamics : IUsb {

        public void Use(object data) {
            Console.WriteLine(this.ToString());
        }

        public override string ToString() {
            return $"{nameof(Dynamics)} connected and ready to be used";
        }
    }
}