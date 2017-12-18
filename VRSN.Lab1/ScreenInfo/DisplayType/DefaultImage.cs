using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VRSN.Lab1 {
    public class DefaultImage : IScreenImage {
        public string Description { get; set; }
        public override string ToString() {
            return Description;
        }
    }
}
