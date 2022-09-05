using System;

namespace Caracter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] frase;
            string maiorPalvra = "";

            while (true)
            {
                frase = Console.ReadLine().Split(' ');
                if (frase[0] == "0")
                {
                    Console.WriteLine();
                    break;
                }
                string palavraSeparada = "";

                for (int i = 0; i < frase.Length; i++)
                {
                    if (frase[i].Length >= maiorPalvra.Length)
                    {
                        maiorPalvra = frase[i];
                    }
                    if (i == (frase.Length - 1))
                    {
                        palavraSeparada += $"{frase[i].Length}";
                    }
                    else
                    {
                        palavraSeparada += $"{frase[i].Length}-";
                    }
                }

                Console.WriteLine(palavraSeparada);
                Console.WriteLine($"The biggest word: {maiorPalvra}");
            }

            
        }
    }
}

