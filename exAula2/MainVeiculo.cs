using System;
using System.Collections.Generic;

class MainVeiculo
{
    static void Main()
    {
        List<Veiculo> lista = new List<Veiculo>();
        int opcao;

        do
        {
            Console.WriteLine("1-Carro 2-Caminhão 0-Sair");
            opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
                lista.Add(new Carro());

            else if (opcao == 2)
            {
                Console.WriteLine("Eixos:");
                int e = int.Parse(Console.ReadLine());

                Caminhao c = new Caminhao();
                c.Eixos = e;
                lista.Add(c);
            }

        } while (opcao != 0);

        double total = 0;

        foreach (var v in lista)
            total += v.CalcularPedagio();

        Console.WriteLine("Total: " + total);
    }
}