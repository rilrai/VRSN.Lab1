using Lab1.BatteryInfo;
using Lab1.ScreenInfo.ScreenType;

namespace Lab1 {
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