using System;

class MainConta
{
    static void Main()
    {
        Conta c1 = new ContaCorrente(100);
        Conta c2 = new ContaPoupanca(100);

        c1.Sacar(30);
        c2.Sacar(30);

        c1.MostrarSaldo();
        c2.MostrarSaldo();
    }
}