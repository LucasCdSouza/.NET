using System;

class Program
{
    static void Main()
    {
        Mensagem e = new Email();
        e.Texto = "Olá pelo email";
        e.Enviar();

        Mensagem s = new SMS();
        s.Texto = "Olá pelo SMS";
        s.Enviar();
    }
}