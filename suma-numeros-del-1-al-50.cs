using System;

public class Program
{
    public static void Main(string[] args)
    {
        int num = 0;
        for (int i = 1; i <=50 ; i++)
        {
            num = i * (i + 1) / 2;
        }

        Console.WriteLine("La suma de los numeros del 1 al 50 es: " + num);
        Console.Read();
    }
}

        