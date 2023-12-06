using System;

public class Program
{
    static void Main(string[] args)
    {
        int numero = 0;
        Console.WriteLine("Ingrese un numero");
        numero = int.Parse(Console.ReadLine());
        incrementarReferencia(ref numero);
        Console.WriteLine("Metodo main: " + numero);
    }

    static void incrementarReferencia(ref int numero)
    {
        numero = numero + 1;
        Console.WriteLine("Metodo: " + numero);
    }
}



