using System;

namespace Lab1.ScreenInfo.DisplayType {
    public class RetinaScreen : ColorScreen {
        public override void Show(IScreenImage screenImage) {
            Console.WriteLine("I am a Retina screen. I'm just as cool as LED but Retina. Here is my image: " +
                              screenImage);
        }
    }
}