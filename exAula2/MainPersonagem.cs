using System;
using System.Collections.Generic;

class MainPersonagem
{
    static void Main()
    {
        List<Personagem> lista = new List<Personagem>();
        Random rnd = new Random();

        for (int i = 0; i < 3; i++)
        {
            if (rnd.Next(2) == 0)
                lista.Add(new Guerreiro());
            else
                lista.Add(new Mago());
        }

        for (int turno = 1; turno <= 3; turno++)
        {
            Console.WriteLine("Turno " + turno);

            foreach (var p in lista)
                p.Atacar();
        }
    }
}