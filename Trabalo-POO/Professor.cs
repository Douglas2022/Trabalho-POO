public class Professor : Pessoa
{
    private string Disciplina;

    public Professor(string nome, string disciplina)
        : base(nome)
    {
        Disciplina = disciplina;
    }

    public override void Apresentar()
    {
        Console.WriteLine(
            $"Olá, sou o professor {Nome} e leciono {Disciplina}."
        );
    }
}
