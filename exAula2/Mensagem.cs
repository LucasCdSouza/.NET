abstract class Mensagem
{
    public string Texto;
    public abstract void Enviar();
}

class Email : Mensagem
{
    public override void Enviar()
    {
        Console.WriteLine("Email: " + Texto);
    }
}

class SMS : Mensagem
{
    public override void Enviar()
    {
        Console.WriteLine("SMS: " + Texto);
    }
}