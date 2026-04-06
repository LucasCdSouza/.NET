using System;

class MainForma
{
    static void Main()
    {
        Console.WriteLine("Digite o lado do quadrado:");
        double lado = double.Parse(Console.ReadLine());

        Quadrado q = new Quadrado();
        q.Lado = lado;

        Console.WriteLine("Área: " + q.CalcularArea());

        Console.WriteLine("Base do retângulo:");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine("Altura do retângulo:");
        double h = double.Parse(Console.ReadLine());

        Retangulo r = new Retangulo();
        r.Base = b;
        r.Altura = h;

        Console.WriteLine("Área: " + r.CalcularArea());
    }
}