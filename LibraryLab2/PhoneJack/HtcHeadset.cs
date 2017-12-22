namespace LibraryLab2.PhoneJack {
    public class HtcHeadset : IPlayback {
        private readonly IOutput _output;

        public HtcHeadset() {
        }

        public HtcHeadset(IOutput output) {
            _output = output;
        }

        public void Play(object data) {
            _output.WriteLine(this.ToString());
        }

        public override string ToString() {
            return $"{nameof(HtcHeadset)} sound";
        }
    }
}