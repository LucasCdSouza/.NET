using System;
using System.Collections.Generic;

class MainAnimal
{
    static void Main()
    {
        List<Animal> animais = new List<Animal>();

        animais.Add(new Cachorro { Nome = "Rex" });
        animais.Add(new Gato { Nome = "Mimi" });

        foreach (var a in animais)
        {
            a.EmitirSom();
        }
    }
}