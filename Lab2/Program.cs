using System;
using System.Text;
using LibraryLab2;
using LibraryLab2.PhoneJack;
using LibraryLab2.Usb;

namespace Lab2 {
    class Program {
        static void Main(string[] args) {
            IOutput output = new ConsoleOutput();
            IPlayback playback = new HtcHeadset();
            IUsb usbDevice = new Charger();

            StringBuilder toConsole = new StringBuilder();
            toConsole.AppendLine("Please select payback device (index expected):");
            toConsole.AppendLine("1 - HtcHeadset");
            toConsole.AppendLine("2 - SamsungHeadset");
            toConsole.AppendLine("3 - XiaomiHeadset");

            Console.WriteLine(toConsole.ToString());

            ConsoleKeyInfo userInput = Console.ReadKey();
            Console.WriteLine();

            switch (userInput.KeyChar) {
                case ('1'):
                    playback = new HtcHeadset(output);
                    break;

                case ('2'):
                    playback = new SamsungHeadset(output);
                    break;

                case ('3'):
                    playback = new XiaomiHeadset(output);
                    break;

                default:
                    Console.WriteLine("You have entered invalid information. HtcHeadset is selected for you");
                    break;
            }

            toConsole = new StringBuilder();
            toConsole.AppendLine("Please select usb device to use (index expected):");
            toConsole.AppendLine("1 - Charger");
            toConsole.AppendLine("2 - Dynamics");
            toConsole.AppendLine("3 - GameConsole");

            Console.WriteLine(toConsole.ToString());

            userInput = Console.ReadKey();
            Console.WriteLine();

            switch (userInput.KeyChar) {
                case ('1'):
                    usbDevice = new Charger();
                    break;

                case ('2'):
                    usbDevice = new Dynamics();
                    break;

                case ('3'):
                    usbDevice = new GameConsole();
                    break;

                default:
                    Console.WriteLine("You have entered invalid information so you will just charge the mobile");
                    break;
            }
            
            Mobile mobile = new Mobile(playback,usbDevice);
            mobile.Play(new object());
            mobile.UsbDevice.Use(new object());

            Console.ReadKey();
        }
    }
}