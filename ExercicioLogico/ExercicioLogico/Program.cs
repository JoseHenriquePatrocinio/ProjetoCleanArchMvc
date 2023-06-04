
using ExercicioLogico;
using System.Globalization;

Triangulo x, y;

x = new Triangulo();
y = new Triangulo();

Console.WriteLine("Entre com as medidas do triangulo x: ");
x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Entre com as medidas do triangulo y: ");
y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


double areax = x.CalculaAreaTriangulo();
double areay = y.CalculaAreaTriangulo();

Console.WriteLine("Area de x = " + areax.ToString("F4", CultureInfo.InvariantCulture));
Console.WriteLine("Area de y = " + areay.ToString("F4", CultureInfo.InvariantCulture));

if (areax > areay)
{
    Console.WriteLine("Maior area: X");
}
else
{
    Console.WriteLine("Maior area: Y");
}