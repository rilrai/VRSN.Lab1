using System;
using System.Text;
using LibraryLab2.PhoneJack;

namespace Lab2 {
    class Program {
        static void Main(string[] args) {
            IOutput output = new ConsoleOutput();

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
                    IPlayback htc = new HtcHeadset(output);
                    htc.Play(output);
                    break;

                case ('2'):
                    IPlayback samsung = new SamsungHeadset(output);
                    samsung.Play(output);
                    break;

                case ('3'):
                    IPlayback xiaomi = new XiaomiHeadset(output);
                    xiaomi.Play(output);
                    break;

                default:
                    Console.WriteLine("You have entered invalid information");
                    break;
            }
        }
    }
}