using System;
using System.Collections.Generic;

abstract class Animal
{
    public string Name { get; set; }
    public abstract void EmitirSom();
}

class Cachorro : Animal
{
    public override void EmitirSom()
    {
        Console.WriteLine("Au au!");
    }
}

class Gato : Animal
{
    public override void EmitirSom()
    {
        Console.WriteLine("Miau!");
    }
}