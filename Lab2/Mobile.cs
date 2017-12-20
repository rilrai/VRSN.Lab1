using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab2.PhoneJack;

namespace Lab2 {
    public class Mobile {
        public IPlayback PlaybackComponent { get; set; }

        public void Play(object data) {
            PlaybackComponent.Play(data);
        }
    }
}
