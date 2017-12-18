using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VRSN.Lab1 {
    public class ColorScreen : ScreenBase {
        public override void Show(IScreenImage screenImage) {
            Console.WriteLine("I am a Color Screen and here is my colorful image: " + screenImage);
        }
    }
}
