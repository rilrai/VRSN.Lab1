using System;

namespace VRSN.Lab1.ScreenInfo.DisplayType {
    public class MonochromeScreen : ScreenBase {
        public override void Show(IScreenImage screenImage) {
            Console.WriteLine("I am Monochrome Screen and there is my image: " + screenImage);
        }
    }
}