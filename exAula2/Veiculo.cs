class Veiculo
{
    public virtual double CalcularPedagio()
    {
        return 0;
    }
}

class Carro : Veiculo
{
    public override double CalcularPedagio()
    {
        return 10;
    }
}

class Caminhao : Veiculo
{
    public int Eixos;

    public override double CalcularPedagio()
    {
        return 10 * Eixos;
    }
}