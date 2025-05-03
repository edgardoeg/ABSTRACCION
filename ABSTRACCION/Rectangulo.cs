

namespace ABSTRACCION
{
    public class Rectangulo : Figura

    {
        public double Base { get; set; }

        public double Altura { get; set; }

        public override double Area()
        {
            return Base * Altura;
        }

        public override double Perimetro()
        {
            return 2 * (Base + Altura);
        }
    }
}
