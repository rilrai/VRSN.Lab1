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

            mob.MobScreen = new SingleTouchScreen(100, 10, 999999, "1024x720");
            mob.MobBattery = new RemovableBattery(BatteryTypes.NickelCadmium, 4100);

            Console.WriteLine(mob.MobScreen.ScreenInfo());
            mob.MobScreen.Touch();

            Console.WriteLine(mob.MobBattery.ToString());
            Console.WriteLine(mob.MobBattery.Type + " battery with volume of " + mob.MobBattery.Volume);

            Console.ReadLine();

        }
    }
}
