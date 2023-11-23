using System;

public class Unit
{
    static void Celcius(double grados)
    {
        double resultado = (grados - 32) / 1.8;
        Console.WriteLine($"La conversion de Fahrenheit a Celsius es: {resultado}");

    }
    static void Fahrenheit(double grados)
    {
        double resultado = (grados * 1.8) + 32;
        Console.WriteLine($"La conversion de Celcius a Fahrenheit es: {resultado}");
    }
    public static void Main(string[] args)
    {

        Console.Clear();
        Console.WriteLine("------Convertidor------\n");
        Console.WriteLine("Ingresa la conversion que deseas realizar");
        Console.WriteLine("1. Celcius a Farenheit");
        Console.WriteLine("2. Farenheit a Celcius");

        int selec = int.Parse(Console.ReadLine()!);
        Console.Clear();

        Console.WriteLine("Ingresa los grados");
        double resultado = double.Parse(Console.ReadLine()!);
        



        switch (selec)
        {
            case 1:
                Celcius(resultado);
                break;
            case 2:
                Fahrenheit(resultado);
                break;
            default:
                Console.WriteLine("Instruccion no existe. Eliga una opcion valida del menu");
                break;
        }

        Console.WriteLine("Presione cualquier tecla para continuar");
        Console.WriteLine("Presione la tecla ESC para salir...");



        
        
    }
}
   


   
        




        


    