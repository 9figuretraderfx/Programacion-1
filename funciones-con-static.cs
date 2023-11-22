using System;

public class Program
{
    static double Suma(double num1, double num2)
    {
        return num1 + num2;
    }
    static double Resta(double num1, double num2)
    {
        return num1 - num2;
    }
    static double Multiplicacion(double num1, double num2)
    {
        return num1 * num2;
    }
    static double Division(double num1, double num2)
    {
        if (num2 != 0)
        {
            return num1 / num2;
        }
        else
        {
            return -1;
        }
       
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Ingresa un numero");
        double num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingresa un numero");
        double num2 = double.Parse(Console.ReadLine());

        Console.WriteLine("La suma es: " + Suma (num1, num2));

        Console.WriteLine("La resta es: " + Resta(num1, num2));

        Console.WriteLine("La Multiplicacion es: " + Multiplicacion (num1, num2));

        if (Division(num1, num2) == -1)
        {
            Console.WriteLine("No se puede hacer una division entre 0");


        }
        else
        {
            double resultado = Division(num1, num2);
            Console.WriteLine("La division es: " + resultado);
        }
    }
}
