using System;

class MainBiblioteca
{
    static void Main()
    {
        Livro l = new Livro();
        l.Titulo = "Clean Code";
        l.ExibirDestaque();

        Revista r = new Revista();
        r.Titulo = "Tech";
        r.Edicao = 10;
        r.ExibirDestaque();
    }
}