using System;

class Program {
    public static void Main(string[] args) {
        int num1 = 0;
        int num2 = 0;

        Console.WriteLine("Ingresa el primer numero: ");
        num1 = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Ingresa el segundo numero: ");
        num2 = Convert.ToInt16(Console.ReadLine());

        if (num1 > num2)
        {
            Console.WriteLine("El numero mayor es:" + num1);
        }
        else {
            Console.WriteLine("El numero mayor es:" + num2);
        }
    }
}