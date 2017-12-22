using System;
using LibraryLab2.PhoneJack;

namespace Lab2 {
    class ConsoleOutput : IOutput {
        public void Write(string text) {
            Console.Write(text);
        }

        public void WriteLine(string text) {
            Console.WriteLine(text);
        }
    }
}