namespace LibraryLab2.PhoneJack {
    public class SamsungHeadset : IPlayback {
        private readonly IOutput _output;

        public SamsungHeadset() {
        }

        public SamsungHeadset(IOutput output) {
            _output = output;
        }

        public void Play(object data) {
            _output.WriteLine(this.ToString());
        }

        public override string ToString() {
            return $"{nameof(SamsungHeadset)} sound";
        }
    }
}