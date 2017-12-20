using System;

namespace Lab1 {
    public class Microphone {
        private bool _isMuted;

        public bool IsMuted {
            get { return _isMuted; }
            set {
                _isMuted = value;
                if (value) {
                    Console.WriteLine("Microphone is muted");
                }
                else {
                    Console.WriteLine("Microphone is unmuted. Current sensetivity is " + _sensetivity);
                }
            }
        }

        private int _sensetivity;

        public int Sensetivity {
            get { return _sensetivity; }
            set {
                if (value <= 10 && value > 0) {
                    _sensetivity = value;
                    _isMuted = false;
                    Console.WriteLine("Microphone sensetivity is set to " + value + " and the microphone is unmuted!");
                }
                else if (value == 0) {
                    _isMuted = true;
                    Console.WriteLine("Microphone sensetivity is set to zero (muted)");
                }
                else {
                    Console.WriteLine("wrong sensetivity value for microphone. Max value is 10. Current is " +
                                      _sensetivity);
                }
            }
        }

        public Microphone(bool muted, int sens) {
            _isMuted = muted;
            if (sens <= 10 && sens > 0) {
                _sensetivity = sens;
            }
            else {
                _sensetivity = 5;
            }
        }

        public Microphone() {
            _isMuted = false;
            _sensetivity = 5;
        }
    }
}