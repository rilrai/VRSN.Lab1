using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VRSN.Lab1
{
    class SingleTouchScreen : TouchScreen 
    {

        public SingleTouchScreen(int height, int width, int numOfColors, string resolution, ScreenBase screenBase) 
        {
            Height = height;
            Width = width;
            NumberOfColors = numOfColors;
            Resolution = resolution;
            Dysplay = screenBase;

        }

        public override string Type() 
        {
            return "This device has a Single Touch screen";
        }
    }
}
