using System;
using System.Collections.Generic;

List<Pessoa> pessoas = new List<Pessoa>();

pessoas.Add(new Aluno("João", 8.0, 9.0));
pessoas.Add(new Professor("Maria", "Programação"));
pessoas.Add(new Aluno("Carlos", 7.0, 8.0));
pessoas.Add(new Professor("Ana", "Banco de Dados"));

foreach (Pessoa pessoa in pessoas)
{
    pessoa.Apresentar();

    if (pessoa is Aluno aluno)
    {
        Console.WriteLine(
            $"Desempenho: {aluno.CalcularDesempenho()}"
        );
    }

    Console.WriteLine();
}