using System;


public class Program
{
    static void A(int vocales)
    {
        int numVocales = 0;
        Console.WriteLine($"La palabra tiene {numVocales} vocales A");
    }

    static void E(int vocales)
    {
        int numVocales = 0;
        Console.WriteLine($"La palabra tiene {numVocales} vocales E");
    }

    static void I(int vocales)
    {
        int numVocales = 0;
        Console.WriteLine($"La palabra tiene {numVocales} vocales I");
    }

    static void O(int vocales)
    {
        int numVocales = 0;
        Console.WriteLine($"La palabra tiene {numVocales} vocales O");
    }

    static void U(int vocales)
    {
        int numVocales = 0;
        Console.WriteLine($"La palabra tiene {numVocales} vocales U");
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Escribe una palabra: ");
        string palabra = Console.ReadLine().ToLower();
        int numVocales = 0;

        for (int i = 0; i < palabra.Length; i++)
        {
            if (palabra[i] == 'a' || palabra[i] == 'e' || palabra[i] == 'i' || palabra[i] == 'o' || palabra[i] == 'u')
            {
                numVocales++;
            }
        }
        Console.WriteLine($"La cantidad de vocales en la palabra es de: " + numVocales);
        Console.ReadLine();
    }
}

        





