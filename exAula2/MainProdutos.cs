using System;

class MainProdutos
{
    static void Main()
    {
        Carrinho c = new Carrinho();

        c.produtos.Add(new ProdutoNacional { Preco = 100 });
        c.produtos.Add(new ProdutoImportado { Preco = 100 });

        Console.WriteLine("Total: " + c.Total());
    }
}