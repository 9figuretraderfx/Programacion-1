using System;
class Program
{
    public static void Main(String[] args)
    {
        int resultado = 0;
        for (int i = 1; i <= 15; i++)
        {
            resultado = i * (i + 1) / 2;
        }

        Console.WriteLine("La suma de los numeros del 1 al 15 es: " + resultado);
        Console.Read();
    }
}




