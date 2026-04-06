abstract class Produto
{
    public double Preco;
    public abstract double PrecoFinal();
}

class ProdutoNacional : Produto
{
    public override double PrecoFinal()
    {
        return Preco;
    }
}

class ProdutoImportado : Produto
{
    public override double PrecoFinal()
    {
        return Preco + (Preco * 0.20) + 10;
    }
}

class Carrinho
{
    public List<Produto> produtos = new List<Produto>();

    public double Total()
    {
        double total = 0;

        foreach (var p in produtos)
            total += p.PrecoFinal();

        return total;
    }
}