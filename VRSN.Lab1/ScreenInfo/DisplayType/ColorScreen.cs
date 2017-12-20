using System;

namespace Lab1.ScreenInfo.DisplayType {
    public class ColorScreen : ScreenBase {
        public override void Show(IScreenImage screenImage) {
            Console.WriteLine("I am a Color Screen and here is my colorful image: " + screenImage);
        }
    }
}