using System;

public class Program
{
    public static void Main(string[] args)
    {
        int vocal;

        Console.WriteLine("Ingrese un numero");
        vocal = Convert.ToInt32(Console.ReadLine());

        switch (vocal)
        {
            case 1:
                Console.WriteLine("A");
                break;
            case 2:
                Console.WriteLine("E");
                break;
            case 3:
                Console.WriteLine("I");
                break;
            case 4:
                Console.WriteLine("O");
                break;
            case 5:
                Console.WriteLine("U");
                break;
          
            default:
                Console.WriteLine("Esa vocal no existe");
                break;
        }
    }
}


