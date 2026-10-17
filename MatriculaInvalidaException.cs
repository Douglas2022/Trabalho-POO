using System;

// Exceção personalizada para matrícula inválida
public class MatriculaInvalidaException : Exception
{
    public MatriculaInvalidaException(string mensagem)
        : base(mensagem)
    {
    }
}