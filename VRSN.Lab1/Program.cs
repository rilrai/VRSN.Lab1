using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VRSN.Lab1
{
    class Program {
        static void Main(string[] args) {
            Mobile mob = new Mobile();
            ScreenBase retina = new RetinaScreen();
            IScreenImage image = new DefaultImage();
            image.Description = "a shiny unicorn!";

            mob.MobScreen = new SingleTouchScreen(100, 10, 999999, "1024x720", retina);
            mob.MobBattery = new RemovableBattery(BatteryTypes.NickelCadmium, 4100);
            mob.MobMicro = new Microphone();

            Console.WriteLine(mob.MobScreen.ScreenInfo());
            mob.MobScreen.Dysplay.Show(image);
            mob.MobScreen.Touch();

            Console.WriteLine(mob.MobBattery.ToString());
            Console.WriteLine(mob.MobBattery.Type + " battery with volume of " + mob.MobBattery.Volume);

            mob.MobMicro.Mute = true;
            mob.MobMicro.Sensetivity = 8;
            mob.MobMicro.Sensetivity = 200;
            mob.MobMicro.Sensetivity = 0;

            Console.ReadLine();

        }
    }
}
