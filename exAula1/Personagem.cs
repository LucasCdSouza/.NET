using System;

public class Personagem
{
    public string Nome;
    public string Posicao;
    public string ItensColetados;

    // Construtor
    public Personagem(string nome, string posicao, string itens)
    {
        Nome = nome;
        Posicao = posicao;
        ItensColetados = itens;
    }

    public void Atacar(double dano)
    {
        Console.WriteLine(Nome + " atacou causando dano de: " + dano);
    }

    public void Movimentar(int direcao)
    {
        switch (direcao)
        {
            case 1:
                Console.WriteLine("Movendo para frente");
                break;
            case 2:
                Console.WriteLine("Movendo para trás");
                break;
            case 3:
                Console.WriteLine("Movendo para direita");
                break;
            case 4:
                Console.WriteLine("Movendo para esquerda");
                break;
            default:
                Console.WriteLine("Direção inválida");
                break;
        }
    }
}