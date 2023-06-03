
using System;

class Program
{
    static void Main(string[] args)
    {
        
        bool a = true;
        bool b = false;

        bool resultadoAnd = a && b; 
        bool resultadoOr = a || b;  
        bool resultadoNot = !a;     

        Console.WriteLine("Exemplo de operadores lógicos:");
        Console.WriteLine("a AND b = " + resultadoAnd);
        Console.WriteLine("a OR b = " + resultadoOr);
        Console.WriteLine("NOT a = " + resultadoNot);
        Console.WriteLine();

       
        int contador = 1;
        Console.WriteLine("Exemplo de laço de repetição while:");
        while (contador <= 5)
        {
            Console.WriteLine("Contador: " + contador);
            contador++;
        }
        Console.WriteLine();

       
        Console.WriteLine("Exemplo de laço de repetição for:");
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("i: " + i);
        }

        Console.ReadLine();
    }
}
