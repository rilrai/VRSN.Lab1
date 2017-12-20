using System;
using System.Text;
using Lab1.ScreenInfo.DisplayType;

namespace Lab1.ScreenInfo.ScreenType {
    public abstract class TouchScreen : Screen {
        public TouchScreen(int height, int width, int numOfColors, string resolution, ScreenBase screenBase)
            : base(height, width, numOfColors, resolution, screenBase) {
        }

        public override void Touch() {
            Console.WriteLine("The screen has been touched and something is going to happen...");
        }

        public abstract int TouchLimit { get; }

        public override string Type() {
            return "This device has a Touch screen";
        }

        public override string ToString() {
            var result = new StringBuilder();
            result.AppendLine(base.ToString());
            result.AppendLine("This screen can be touched this number of times: " + TouchLimit);

            return result.ToString();
        }
    }
}