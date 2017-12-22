using System;

namespace LibraryLab2.Usb {
    public class GameConsole : IUsb {

        public void Use(object data) {
            Console.WriteLine(this.ToString());
        }

        public override string ToString() {
            return $"{nameof(GameConsole)} is ready to be used";
        }
    }
}