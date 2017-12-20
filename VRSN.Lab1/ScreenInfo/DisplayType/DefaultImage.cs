namespace VRSN.Lab1.ScreenInfo.DisplayType {
    public class DefaultImage : IScreenImage {
        public string Description { get; set; }
        public QualityRates Quality { get; set; }

        public DefaultImage(string description, QualityRates quality) {
            Description = description;
            Quality = quality;
        }

        public override string ToString() {
            return $"{Description} that is seen in {Quality} quality.";
        }
    }
}