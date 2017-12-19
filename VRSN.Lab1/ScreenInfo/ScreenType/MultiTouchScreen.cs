using System;

namespace VRSN.Lab1 {
    class MultiTouchScreen : TouchScreen {
        public override string Type() {
            return "This device has a Multi Touch screen which is the coolest screen the wotld has ever seen =)";
        }

        public override void Touch() {
            Console.WriteLine("The screen has been touched, but you can go on and touch it more - it is multitouch!");
        }

        public override int TouchLimit
        {
            get;
        }

        public MultiTouchScreen (int height, int width, int numOfColors, string resolution, ScreenBase screenBase, int touchLimit) 
        {
            Height = height;
            Width = width;
            NumberOfColors = numOfColors;
            Resolution = resolution;
            Dysplay = screenBase;
            TouchLimit = touchLimit;
        }
    }
}
