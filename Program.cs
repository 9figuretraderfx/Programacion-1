using System;

public class Program
{
    public static void Main(string[] args)
    {
        int num, suma = 0;

        
          do  {
            Console.WriteLine("Ingresa un numero");

            num = int.Parse(Console.ReadLine());
                suma = suma + num;
        } while (num != 0) ;

        {
            Console.WriteLine("Tu suma es: " + suma);
            
        }
    }
}
        