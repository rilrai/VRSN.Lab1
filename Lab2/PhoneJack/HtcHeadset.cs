﻿using System;

namespace Lab2.PhoneJack {
    public class HtcHeadset : IPlayback {
        private IOutput _output;

        public HtcHeadset(IOutput output) {
            _output = output;
        }
        public void Play(object data) {
            Console.WriteLine($"{nameof(HtcHeadset)} sound");
        }
    }
}
