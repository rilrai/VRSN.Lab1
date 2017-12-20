using VRSN.Lab1.BatteryInfo;
using VRSN.Lab1.ScreenInfo.ScreenType;

namespace VRSN.Lab1 {
    class Mobile {
        public Screen MobScreen { get; set; }

        public Battery MobBattery { get; set; }

        public Microphone MobMicro { get; set; }

        public Mobile(Screen screen, Battery battery, Microphone micro) {
            MobScreen = screen;
            MobBattery = battery;
            MobMicro = micro;
        }
    }
}