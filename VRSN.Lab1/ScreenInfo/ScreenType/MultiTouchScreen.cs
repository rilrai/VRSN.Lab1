using System;
using VRSN.Lab1.ScreenInfo.DisplayType;

namespace VRSN.Lab1.ScreenInfo.ScreenType {
    class MultiTouchScreen : TouchScreen {
        public MultiTouchScreen(int height, int width, int numOfColors, string resolution, ScreenBase screenBase, int touchLimit)
            : base(height, width, numOfColors, resolution, screenBase) {
            TouchLimit = touchLimit;
        }

        public override string Type() {
            return "This device has a Multi Touch screen which is the coolest screen the wotld has ever seen =)";
        }

        public override void Touch() {
            Console.WriteLine("The screen has been touched, but you can go on and touch it more - it is multitouch!");
        }

        public override int TouchLimit { get; }
    }
}