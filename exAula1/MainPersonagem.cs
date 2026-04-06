using System;

class MainPersonagem
{
    static void Main()
    {
        Console.WriteLine("Criar personagem:");

        Console.WriteLine("Nome:");
        string nome = Console.ReadLine();

        Console.WriteLine("Posição:");
        string posicao = Console.ReadLine();

        Console.WriteLine("Itens coletados:");
        string itens = Console.ReadLine();

        Personagem personagem = new Personagem(nome, posicao, itens);

        Console.WriteLine("\nAtaque do personagem:");
        personagem.Atacar(7.5);

        Console.WriteLine("\nMovimentação do personagem:");
        personagem.Movimentar(1);
    }
}