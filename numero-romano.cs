using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un numero entre el 1 y el 5");

        int numero;
        numero = Convert.ToInt16(Console.ReadLine());

        switch (numero)
        {
            case 1:
                Console.WriteLine("Numero romano: I ");
                break;
            case 2:
                Console.WriteLine("Numero romano: II ");
                break;
            case 3:
                Console.WriteLine("Numero romano: III: ");
                break;
            case 4:
                Console.WriteLine("Numero romano: IV ");
                break;
            case 5:
                Console.WriteLine("Numero romano: V ");
                break;
            default:
                Console.WriteLine("Ingrese un numero entre el 1 y el 5");
                break;
        }
    }
}