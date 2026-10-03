public class Aluno : Pessoa, IAvaliavel
{
    private double Nota1;
    private double Nota2;

    public Aluno(string nome, double nota1, double nota2)
        : base(nome)
    {
        Nota1 = nota1;
        Nota2 = nota2;
    }

    public override void Apresentar()
    {
        Console.WriteLine($"Olá, sou o aluno {Nome}.");
    }

    public double CalcularDesempenho()
    {
        return (Nota1 + Nota2) / 2;
    }
}
