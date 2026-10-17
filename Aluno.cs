public class Aluno
{
    public string Nome { get; private set; }
    public string Matricula { get; private set; }

    private double nota;

    public double Nota
    {
        get { return nota; }

        set
        {
            // Verifica se a nota está entre 0 e 10
            if (value < 0 || value > 10)
            {
                throw new NotaInvalidaException(
                    "A nota deve estar entre 0 e 10."
                );
            }

            nota = value;
        }
    }

    public Aluno(string nome, string matricula)
    {
        Nome = nome;
        Matricula = matricula;
    }
}