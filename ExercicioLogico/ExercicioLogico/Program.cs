
using System.Globalization;

double xa, xb, xc, ya, yb, yc;
Console.WriteLine("Entre com as medidas do triangulo x: ");
xa = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
xb = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
xc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Entre com as medidas do triangulo y: ");
ya = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
yb = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
yc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double p = (xa + xb + xc) / 2.0;
double areax = Math.Sqrt(p * (p - xa) * (p - xb) * (p - xc));
p = (ya + yb + yc) / 2.0;
double areay = Math.Sqrt(p * (p - ya) * (p - yb) * (p - yc));

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