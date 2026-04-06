using System;
using System.Collections.Generic;

class MainFuncionario
{
    static void Main()
    {
        List<Funcionario> lista = new List<Funcionario>();

        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine("1-Vendedor 2-Gerente");
            int tipo = int.Parse(Console.ReadLine());

            Console.WriteLine("Salário base:");
            double baseSalario = double.Parse(Console.ReadLine());

            if (tipo == 1)
            {
                Console.WriteLine("Vendas:");
                double vendas = double.Parse(Console.ReadLine());

                lista.Add(new Vendedor
                {
                    SalarioBase = baseSalario,
                    Vendas = vendas
                });
            }
            else
            {
                Console.WriteLine("Bonus:");
                double bonus = double.Parse(Console.ReadLine());

                lista.Add(new Gerente
                {
                    SalarioBase = baseSalario,
                    Bonus = bonus
                });
            }
        }

        foreach (var f in lista)
        {
            double pagamento = f.CalcularPagamento();
            Console.WriteLine("Pagamento: " + pagamento);

            if (pagamento > 5000)
                Console.WriteLine("⚠️ Alerta de Orçamento!");
        }
    }
}