using Lab1.ScreenInfo.DisplayType;

namespace Lab1.ScreenInfo.ScreenType {
    class SingleTouchScreen : TouchScreen {
        public SingleTouchScreen(int height, int width, int numOfColors, string resolution, ScreenBase screenBase)
            : base(height, width, numOfColors, resolution, screenBase) {
        }

        public override string Type() {
            return "This device has a Single Touch screen";
        }

        public override int TouchLimit {
            get { return 1; }
        }
    }
}