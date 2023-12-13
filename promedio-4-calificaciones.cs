using System;

public class Program
{
    public static void Main(string[] args)
    {
        float cal1, cal2, cal3, cal4, promedio;

        Console.WriteLine("Ingrese calificacion 1");
        cal1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese calificacion 2");
        cal2 = float.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese calificacion 3");
        cal3 = float.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese calificacion 4");
        cal4 = float.Parse(Console.ReadLine());

        promedio = (cal1 + cal2 + cal3 + cal4) / 4;

        if (promedio >= 9.5)
            Console.WriteLine("Tu promedio es 10");
        else
            Console.WriteLine("Tu promedio es: " + promedio);
    }
}







