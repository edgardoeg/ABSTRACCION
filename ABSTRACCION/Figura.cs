
namespace ABSTRACCION
{
    public abstract class Figura
    {

        public abstract double Area();
        public abstract double Perimetro();

        public void Imprimir(string NombreFigura)
        {
            Console.WriteLine($"Area del {NombreFigura}: {Area()} cm2");
            Console.WriteLine($"Perimetro del {NombreFigura}: {Perimetro()} cm");
        }
    }
}
