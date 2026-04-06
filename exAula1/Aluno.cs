using System;

public class Aluno
{
    public string Nome;
    public int Idade;
    public string Curso;
    public int Matricula;

    // Construtor
    public Aluno(string nome, int idade, string curso, int matricula)
    {
        Nome = nome;
        Idade = idade;
        Curso = curso;
        Matricula = matricula;
    }

    // Função para apresentação de dados
    public void ApresentarDados()
    {
        Console.WriteLine("=== Dados do Aluno ===");
        Console.WriteLine("Nome: " + Nome);
        Console.WriteLine("Idade: " + Idade);
        Console.WriteLine("Curso: " + Curso);
        Console.WriteLine("Matrícula: " + Matricula);
    }
}