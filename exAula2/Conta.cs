abstract class Conta
{
    protected double saldo;

    public Conta(double saldoInicial)
    {
        saldo = saldoInicial;
    }

    public abstract void Sacar(double valor);

    public void MostrarSaldo()
    {
        Console.WriteLine("Saldo: " + saldo);
    }
}

class ContaCorrente : Conta
{
    public ContaCorrente(double saldo) : base(saldo) { }

    public override void Sacar(double valor)
    {
        if (saldo >= valor)
            saldo -= valor;
        else
            Console.WriteLine("Saldo insuficiente");
    }
}

class ContaPoupanca : Conta
{
    public ContaPoupanca(double saldo) : base(saldo) { }

    public override void Sacar(double valor)
    {
        double total = valor + 0.50;

        if (saldo >= total)
            saldo -= total;
        else
            Console.WriteLine("Saldo insuficiente");
    }
}