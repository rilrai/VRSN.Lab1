using System;

namespace VRSN.Lab1
{
    class SegmentScreen : Screen 
    {

        public override string Type()
        {
            return "This device has a Segment screen";
        }

        public override void Touch() 
        {
            Console.WriteLine("The screen has been touched to leterally no effect");
        }

        public SegmentScreen(int height, int width, int numOfColors, string resolution, ScreenBase screenBase) 
        {
            Height = height;
            Width = width;
            NumberOfColors = numOfColors;
            Resolution = resolution;
            Dysplay = screenBase;
        }
    }
}
