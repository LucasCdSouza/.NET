class AparelhoSom
{
    protected int volume = 0;

    public virtual void AumentarVolume()
    {
    }
}

class Radio : AparelhoSom
{
    public override void AumentarVolume()
    {
        volume += 1;
        Console.WriteLine($"Radio volume: {volume}");
    }
}

class HomeTheater : AparelhoSom
{
    public override void AumentarVolume()
    {
        volume += 5;
        Console.WriteLine($"Home Theater volume: {volume}");
    }
}