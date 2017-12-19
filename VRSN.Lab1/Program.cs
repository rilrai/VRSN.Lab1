using System;

namespace VRSN.Lab1
{
    class Program 
        {
        static void Main(string[] args) 
            {
            ScreenBase retina = new RetinaScreen();
            IScreenImage image = new DefaultImage("a shiny unicorn!",QualityRates.High);
            Screen screen = new MultiTouchScreen(100, 10, 999999, "1024x720", retina, 5);
            Battery battery = new Battery(BatteryTypes.NickelCadmium, 4100, true);
            Microphone mic = new Microphone();

            Mobile mob = new Mobile(screen, battery, mic);

            Console.WriteLine(mob.MobScreen);
            mob.MobScreen.Dysplay.Show(image);
            mob.MobScreen.Touch();

            Console.WriteLine(mob.MobBattery);
            
            mob.MobMicro.IsMuted = true;
            mob.MobMicro.Sensetivity = 8;
            mob.MobMicro.Sensetivity = 200;
            mob.MobMicro.Sensetivity = 0;

            Console.ReadLine();
        }
    }
}
