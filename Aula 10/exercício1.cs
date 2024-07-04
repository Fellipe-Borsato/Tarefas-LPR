using System;
using System.Collections.Generic;
class HelloWorld
{
    static void Main()
    {
        List<string> nomes = new();
        int numElmentos;
        int cont = 1;

        numElmentos = int.Parse(Console.ReadLine());

        for (int i = 0; i < numElmentos; i++) //adiciona elementos a lista nomes
        {
            String Unome = Console.ReadLine();
            nomes.Add(Unome);
        }


        List<string> ordem = new List<int>();

        foreach (var Unome in nomes)
        {
            int tamanho = Unome.Length;
            if (tamanho < 100)
            {
                ordem[tamanho].Add(Unome);
            }
        }
    }
}

