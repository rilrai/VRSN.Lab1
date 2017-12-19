using System;
using System.Text;

namespace VRSN.Lab1
{
    public abstract class TouchScreen : Screen 
    {

        public override void Touch() 
        {
            Console.WriteLine("The screen has been touched and something is going to happen...");
        }

        public abstract int TouchLimit { get; }

        public override string Type() 
        {
            return "This device has a Touch screen";
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.AppendLine(base.ToString());
            result.AppendLine("This screen can be touched this number of times: "+  TouchLimit);

            return result.ToString();
        }
    }
}
