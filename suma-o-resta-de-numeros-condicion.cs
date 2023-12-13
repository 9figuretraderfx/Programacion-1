using System;
class Program
{
    public static void Main(string[] args)
    {
        int n1, n2, r;
        Console.WriteLine("Ingresar numero 1");
        n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingresar numero 2");
        n2 = int.Parse(Console.ReadLine());
        if (n1 > n2)
            r = n1 + n2;
        else if (n1 > n2)
            r = n1 - n2;
        else
            r = n1 + n2;
        Console.WriteLine("El resutado es: " + r);
    }
}


