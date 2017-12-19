using System;

namespace VRSN.Lab1
{
    class Program 
        {
        static void Main(string[] args) 
            {
            Mobile mob = new Mobile();
            ScreenBase retina = new RetinaScreen();
            IScreenImage image = new DefaultImage("a shiny unicorn!",QualityRates.High);

            mob.MobScreen = new SingleTouchScreen(100, 10, 999999, "1024x720", retina);
            mob.MobBattery = new Battery(BatteryTypes.NickelCadmium, 4100, true);
            mob.MobMicro = new Microphone();

            Console.WriteLine(mob.MobScreen.ScreenInfo());
            mob.MobScreen.Dysplay.Show(image);
            mob.MobScreen.Touch();

            Console.WriteLine(mob.MobBattery.ToString());
            
            mob.MobMicro.IsMuted = true;
            mob.MobMicro.Sensetivity = 8;
            mob.MobMicro.Sensetivity = 200;
            mob.MobMicro.Sensetivity = 0;

            Console.ReadLine();
        }
    }
}
