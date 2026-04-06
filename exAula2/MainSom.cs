using System;
using System.Collections.Generic;

class MainSom
{
    static void Main()
    {
        List<AparelhoSom> aparelhos = new List<AparelhoSom>();

        aparelhos.Add(new Radio());
        aparelhos.Add(new HomeTheater());

        foreach (var a in aparelhos)
        {
            a.AumentarVolume();
        }
    }
}