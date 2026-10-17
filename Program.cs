
using System;

public class Program
{
    // Método para matricular um aluno
    public static Aluno Matricular(string nome, string matricula)
    {
        if (string.IsNullOrWhiteSpace(nome) ||
            string.IsNullOrWhiteSpace(matricula))
        {
            throw new MatriculaInvalidaException(
                "Nome e matrícula são obrigatórios."
            );
        }

        return new Aluno(nome, matricula);
    }

    public static void Main()
    {
        // Teste 1: matrícula e nota válidas
        try
        {
            Aluno aluno = Matricular("Douglas", "2026001");
            aluno.Nota = 8.5;

            Console.WriteLine("Matrícula realizada com sucesso!");
            Console.WriteLine($"Nome: {aluno.Nome}");
            Console.WriteLine($"Matrícula: {aluno.Matricula}");
            Console.WriteLine($"Nota: {aluno.Nota}");
        }
        catch (MatriculaInvalidaException ex)
        {
            Console.WriteLine($"Erro na matrícula: {ex.Message}");
        }
        catch (NotaInvalidaException ex)
        {
            Console.WriteLine($"Erro na nota: {ex.Message}");
        }

        // Teste 2: matrícula sem nome
        try
        {
            Matricular("", "2026002");
        }
        catch (MatriculaInvalidaException ex)
        {
            Console.WriteLine($"Erro esperado: {ex.Message}");
        }

        // Teste 3: nota inválida
        try
        {
            Aluno aluno = Matricular("Maria", "2026003");
            aluno.Nota = 11;
        }
        catch (MatriculaInvalidaException ex)
        {
            Console.WriteLine($"Erro na matrícula: {ex.Message}");
        }
        catch (NotaInvalidaException ex)
        {
            Console.WriteLine($"Erro esperado: {ex.Message}");
        }
    }
}
