using System;

class MainLivro
{
    static void Main()
    {
        Console.WriteLine("Cadastro do primeiro livro:");

        Console.WriteLine("Título:");
        string titulo1 = Console.ReadLine();

        Console.WriteLine("Autor:");
        string autor1 = Console.ReadLine();

        Console.WriteLine("Ano:");
        int ano1 = int.Parse(Console.ReadLine());

        Livro livro1 = new Livro(titulo1, autor1, ano1);

        Console.WriteLine("\nCadastro do segundo livro:");

        Console.WriteLine("Título:");
        string titulo2 = Console.ReadLine();

        Console.WriteLine("Autor:");
        string autor2 = Console.ReadLine();

        Console.WriteLine("Ano:");
        int ano2 = int.Parse(Console.ReadLine());

        Livro livro2 = new Livro(titulo2, autor2, ano2);

        Console.WriteLine("\nDados dos livros:");
        livro1.MostrarDados();
        Console.WriteLine();
        livro2.MostrarDados();

        Console.WriteLine("\nEmprestando o primeiro livro...");
        livro1.Emprestar();
        livro1.MostrarDados();
    }
}