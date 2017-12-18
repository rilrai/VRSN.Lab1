using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VRSN.Lab1 {
    public class Microphone {
        private bool _muted = false;
        private int _sensetivity = 5;
        public bool Mute {
            get {
                return _muted;
            }
            set {
                _muted = value;
                if (value) {
                    Console.WriteLine("Microphone is muted");
                }
                else {
                    Console.WriteLine("Microphone is unmuted. Current sensetivity is " + _sensetivity);
                }
            }
        }
        public int Sensetivity {
            get {
                return _sensetivity;
            }
            set {
                if ((value < 11) && (value > 0)) {
                    _sensetivity = value;
                    _muted = false;
                    Console.WriteLine("Microphone sensetivity is set to " + value + " and the microphone is unmuted!");
                }
                else if (value == 0) {
                    _muted = true;
                    Console.WriteLine("Microphone sensetivity is set to zero (muted)");
                }
                else {
                    Console.WriteLine("wrong sensetivity value for microphone. Max value is 10. Current is " + _sensetivity);
                }
            }
        }

    }
}
