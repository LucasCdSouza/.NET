using System;

public class Livro
{
    public string Titulo;
    public string Autor;
    public int Ano;
    public bool Emprestado;

    // Construtor
    public Livro(string titulo, string autor, int ano)
    {
        Titulo = titulo;
        Autor = autor;
        Ano = ano;
        Emprestado = false;
    }

    public void Emprestar()
    {
        Emprestado = true;
        Console.WriteLine("Livro emprestado.");
    }

    public void Devolver()
    {
        Emprestado = false;
        Console.WriteLine("Livro devolvido.");
    }

    public void MostrarDados()
    {
        Console.WriteLine("Título: " + Titulo);
        Console.WriteLine("Autor: " + Autor);
        Console.WriteLine("Ano: " + Ano);
        Console.WriteLine("Emprestado: " + Emprestado);
    }
}