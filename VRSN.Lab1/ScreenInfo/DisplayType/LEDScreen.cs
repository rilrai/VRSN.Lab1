using System;
using VRSN.Lab1.ScreenInfo.DisplayType;

namespace VRSN.Lab1.ScreenInfo.DisplayType {
    public class LedScreen : ColorScreen {
        public override void Show(IScreenImage screenImage) {
            Console.WriteLine(
                "I am cool LED screen. My image has higher quality than an ordinary color screen. Just look at it! " +
                screenImage);
        }
    }
}