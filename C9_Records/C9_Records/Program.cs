
var cliente1 = new Cliente("Maria", 34);
Console.WriteLine(cliente1.Nome);
Console.WriteLine(cliente1.Idade);

var cliente2 = cliente1 with { Idade = 35 };
Console.WriteLine(cliente2.Nome);
Console.WriteLine(cliente2.Idade);

Console.WriteLine(cliente1.Equals(cliente2));
Console.WriteLine(cliente1 == cliente2);

var cliente3 = new Cliente("Maria", 34);

Console.WriteLine(cliente1.Equals(cliente3));
Console.WriteLine(cliente1 == cliente3);

Console.ReadLine();

public record Cliente
{
    public string Nome;
    public int Idade;

    public Cliente(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
}
