using System;
namespace TiposDadosBasicos
{
    class Program
    {
        static void Main(string[] args)
        {
            object obj = null;
            string nome = "Green";//cadeia unicode
            bool completo = false; //true/false
            char letra = '\u0041'; //caractere unicode
            sbyte x = 100; //-128 to 127
            byte n1 = 126; //0 to 255
            int n2 = int.MaxValue; //-2^31 to 2^31-1
            long n3 = long.MaxValue; // -2^63 to 2^63-1
            float n4 = float.MinValue;
            double n5 = double.MinValue;
            decimal n6 = decimal.MaxValue;

            Console.WriteLine(nome);
            Console.WriteLine(letra);
            Console.WriteLine(completo);
            Console.WriteLine(x);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            


        }
    }
}
