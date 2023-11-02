using System;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

public class Program
{
    public static void Main(string[] args)
    {
        int anio = 0;

        int[] aniobiciesto = new int[1];

        Console.WriteLine("Ingrese el anio a evaluar");
        anio = int.Parse(Console.ReadLine());

        if (anio % 4 != 0)
            Console.WriteLine("No es biciesto");

        if (anio % 4 == 0 && anio % 100 != 0)
            Console.WriteLine("Es biciesto");

        if (anio % 4 == 0 && anio % 100 == 0 && anio % 400 == 0)
            Console.WriteLine("Es biciesto");

        else if (anio % 4 == 0 && anio % 100 == 0 && anio % 400 != 0)
            Console.WriteLine("No es biciesto");
    }
}








