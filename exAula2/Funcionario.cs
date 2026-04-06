abstract class Funcionario
{
    public double SalarioBase;
    public abstract double CalcularPagamento();
}

class Vendedor : Funcionario
{
    public double Vendas;

    public override double CalcularPagamento()
    {
        return SalarioBase + (Vendas * 0.10);
    }
}

class Gerente : Funcionario
{
    public double Bonus;

    public override double CalcularPagamento()
    {
        return SalarioBase + Bonus;
    }
}