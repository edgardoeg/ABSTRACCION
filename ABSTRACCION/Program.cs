using ABSTRACCION;

Circulo circulo = new Circulo();

Rectangulo rectangulo = new Rectangulo();

const string CIRCULO = "Circulo";
const string RECTANGULO = "Rectangulo";

Console.Write("Ingrese el radio: ");
circulo.Radio = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese la base: ");
rectangulo.Base = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese la altura: ");
rectangulo.Altura = Convert.ToDouble(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("Circulo: ");
circulo.Imprimir(CIRCULO);

Console.WriteLine();
Console.WriteLine("Rectangulo: ");
rectangulo.Imprimir(RECTANGULO);
