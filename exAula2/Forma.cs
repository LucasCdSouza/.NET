abstract class Forma
{
    public abstract double CalcularArea();
}

class Quadrado : Forma
{
    public double Lado;

    public override double CalcularArea()
    {
        return Lado * Lado;
    }
}

class Retangulo : Forma
{
    public double Base;
    public double Altura;

    public override double CalcularArea()
    {
        return Base * Altura;
    }
}