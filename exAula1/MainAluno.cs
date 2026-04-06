using System;

class MainAluno
{
    static void Main()
    {
        Console.WriteLine("Digite o nome do aluno:");
        string nome = Console.ReadLine();

        Console.WriteLine("Digite a idade:");
        int idade = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o curso:");
        string curso = Console.ReadLine();

        Console.WriteLine("Digite a matrícula:");
        int matricula = int.Parse(Console.ReadLine());

        Aluno aluno = new Aluno(nome, idade, curso, matricula);

        Console.WriteLine();
        aluno.ApresentarDados();
    }
}