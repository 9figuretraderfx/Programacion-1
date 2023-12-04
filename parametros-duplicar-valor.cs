using System;

public class Program
{
    static int incrementarReferencia(int x)
    {
        int numIncrementado = (x + 1);
        return numIncrementado;

    }

    public static void Main(string[] args)
    {

        string[] numeros = new string[5];
        int x = int.Parse(Console.ReadLine()); 
        x = incrementarReferencia(x);

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Ingresa un numero");
            numeros[i] = Console.ReadLine();
        }
        
        Console.WriteLine($"Los numeros incrementados son {x}");
        
    }
}

