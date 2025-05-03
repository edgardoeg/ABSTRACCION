

namespace ABSTRACCION
{
    public class Circulo : Figura
    {
        public double Radio { get; set; }
        public override double Area()
        {
            return Math.Round(Math.PI * Math.Pow(Radio, 2));
        }

        public override double Perimetro()
        {
            return Math.Round(2*Math.PI * Radio);
        }
    }
}
