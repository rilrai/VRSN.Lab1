using LibraryLab2.PhoneJack;

namespace LibraryLab2 {
    public class Mobile {
        public IPlayback PlaybackComponent { get; set; }

        public Mobile(IPlayback playback) {
            PlaybackComponent = playback;
        }

        public void Play(object data) {
            PlaybackComponent.Play(data);
        }
    }
}
