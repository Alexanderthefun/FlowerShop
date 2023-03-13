namespace Flowershop
{
public class Hibiscus : IMothersDayFlower
    {
        public string Color { get; set; }
        public int PetalCount { get; set; }
        public string Species { get; set; }
        public double StemLength { get; set; }
        public bool Thorny { get; set; }

        public override string ToString()
        {
            return $"A fat {Color} hibiscus with a {StemLength}-long stem.";
        }
    }

}
