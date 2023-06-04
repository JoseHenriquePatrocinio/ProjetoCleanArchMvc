

using System;
using System.Globalization;

namespace ExercicioLogico2
{
    internal class Program
    {
        static void Main(string[] args)
        {

           
            Console.WriteLine("Entre os dados do produto");

            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Produto produto = new Produto(nome, preco);

            Console.WriteLine();
            Console.WriteLine("Dados produto: " + produto);

            Console.WriteLine();
            Console.WriteLine("Digite a quantidade a ser adicionada no estoque: ");
            int qte = int.Parse(Console.ReadLine());
            produto.AddProdutoEstoque(qte);

            Console.WriteLine("Dados produto: " + produto);

            Console.WriteLine();
            Console.WriteLine("Digite a quantidade a ser removida no estoque: ");
            qte = int.Parse(Console.ReadLine());
            produto.RemoveProdutoEstoque(qte);

            Console.WriteLine("Dados produto: " + produto);


        }
    }
}
