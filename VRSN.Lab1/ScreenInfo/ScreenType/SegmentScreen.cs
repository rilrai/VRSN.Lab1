using System;
using Lab1.ScreenInfo.DisplayType;

namespace Lab1.ScreenInfo.ScreenType {
    class SegmentScreen : Screen {
        public override string Type() {
            return "This device has a Segment screen";
        }

        public override void Touch() {
            Console.WriteLine("The screen has been touched to leterally no effect");
        }

        public SegmentScreen(int height, int width, int numOfColors, string resolution, ScreenBase screenBase)
            : base(height, width, numOfColors, resolution, screenBase) {
        }
    }
}