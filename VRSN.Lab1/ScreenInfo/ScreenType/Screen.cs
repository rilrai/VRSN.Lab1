using System.Text;
using VRSN.Lab1.ScreenInfo.DisplayType;

namespace VRSN.Lab1.ScreenInfo.ScreenType {
    public abstract class Screen {
        public int Height { get; set; }

        public int Width { get; set; }

        public int NumberOfColors { get; set; }

        public string Resolution { get; set; }

        public ScreenBase Dysplay { get; set; }

        public Screen(int height, int width, int numOfColors, string resolution, ScreenBase screenBase) {
            Height = height;
            Width = width;
            NumberOfColors = numOfColors;
            Resolution = resolution;
            Dysplay = screenBase;
        }
    
        public string Size() {
            return Height + "x" + Width;
        }

        public abstract void Touch();

        public abstract string Type();

        public override string ToString() {
            var info = new StringBuilder();
            info.AppendLine("Screen parameters are:");
            info.AppendLine(this.Type());
            info.AppendLine("Size: " + this.Size());
            info.AppendLine("Resolution: " + this.Resolution);
            info.AppendLine("Number of Colors: " + this.NumberOfColors);

            return info.ToString();
        }
    }
}