using LibraryLab2.PhoneJack;
using LibraryLab2.Usb;

namespace LibraryLab2 {
    public class Mobile {
        public IPlayback PlaybackComponent { get; set; }
        public IUsb UsbDevice { get; set; }

        public Mobile(IPlayback playback, IUsb usb) {
            PlaybackComponent = playback;
            UsbDevice = usb;
        }

        public void Play(object data) {
            PlaybackComponent.Play(data);
        }

        public void UseUsb(object data) {
            UsbDevice.Use(data);
        }     
    }
}
