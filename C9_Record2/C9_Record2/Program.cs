Aluno aluno1 = new Aluno { Nome = "Amanda", Email = "amanda@teste.com", Curso = "Fisica" };

Console.WriteLine(aluno1.Nome);
Console.WriteLine(aluno1.Email);
Console.WriteLine(aluno1.Curso);
public record Pessoa
{
    public string Nome;
    public string Email;
}
public record Aluno : Pessoa
{
    public string Curso;
}

