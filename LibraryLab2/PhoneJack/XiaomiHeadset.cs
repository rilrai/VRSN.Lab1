namespace LibraryLab2.PhoneJack {
    public class XiaomiHeadset : IPlayback {
        private readonly IOutput _output;

        public XiaomiHeadset() {
        }

        public XiaomiHeadset(IOutput output) {
            _output = output;
        }

        public void Play(object data) {
            _output.WriteLine(this.ToString());
        }

        public override string ToString() {
            return $"{nameof(XiaomiHeadset)} sound";
        }
    }
}