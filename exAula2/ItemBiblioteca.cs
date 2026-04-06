abstract class ItemBiblioteca
{
    public string Titulo;
    public string Autor;

    public abstract void ExibirDestaque();
}

class Livro : ItemBiblioteca
{
    public override void ExibirDestaque()
    {
        Console.WriteLine(Titulo.ToUpper());
    }
}

class Revista : ItemBiblioteca
{
    public int Edicao;

    public override void ExibirDestaque()
    {
        Console.WriteLine($"{Titulo} - Edição {Edicao}");
    }
}