namespace VRSN.Lab1
{
    public class DefaultImage : IScreenImage
    {
        public string Description { get; set; }
        public QualityRates Quality { get; set; }
        public DefaultImage(string description, QualityRates quality)
        {
            Description = description;
            Quality = quality;
        }
        public override string ToString()
        {
            return string.Format("{0} that is seen in {1} quality.", Description, Quality);
        }
    }
}
