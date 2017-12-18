using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VRSN.Lab1 {
    public class LEDScreen : ColorScreen {
        public override void Show(IScreenImage screenImage) {
            Console.WriteLine("I am cool LED screen. My image has higher quality than an ordinary color screen. Just look at it! " + screenImage);
        }
    }
}
