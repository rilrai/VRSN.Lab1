using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VRSN.Lab1
{
    public abstract class TouchScreen : Screen 
    {

        public override void Touch() 
        {
            Console.WriteLine("The screen has been touched and something is going to happen...");
        }

        public override string Type() 
        {
            return "This device has a Touch screen";
        }

    }
}
