class Personagem
{
    public virtual void Atacar() { }
}

class Guerreiro : Personagem
{
    public override void Atacar()
    {
        Console.WriteLine("Ataque com Espada");
    }
}

class Mago : Personagem
{
    public override void Atacar()
    {
        Console.WriteLine("Ataque com Magia");
    }
}