

namespace ExercicioLogico
{
    class Triangulo
    {

        public double A;
        public double B;
        public double C;

        public double CalculaAreaTriangulo()
        {
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));

        }

    }
}
