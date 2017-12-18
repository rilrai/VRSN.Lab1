using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VRSN.Lab1
{
    public abstract class Screen {
        public int Height { get; set; }
        public int Width { get; set; }
        public int NumberOfColors { get; set; }
        public string Resolution { get; set; }

        public string Size() {
            return Height + "x" + Width;
        }

        public abstract void Touch();

        public abstract string Type();
        public string ScreenInfo() {
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
