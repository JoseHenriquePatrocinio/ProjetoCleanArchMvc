

using System;
using System.Globalization;

namespace ExercicioLogico2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Produto produto = new Produto();

            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            produto.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade em estoque: ");
            produto.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

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
