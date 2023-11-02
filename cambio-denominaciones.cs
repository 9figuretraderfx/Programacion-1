using System;

public class Program
{
    public static void Main(string[] args)
    {
        int cantidad = 0, cambio = 0;

        int[] feria = new int[6];
        int[] billetes = { 20, 50, 100, 200, 600, 1000 };

        Console.WriteLine("Ingrese la cantidad que desea cambiar");
        cantidad = int.Parse(Console.ReadLine());
        for (int i = billetes.Length - 1; i >= 0; i--)
        {
            if (cantidad >= billetes[i]) ;
            {
                int numDebilletes = cantidad / billetes[i];
                Console.WriteLine($"Entregue {numDebilletes} de {billetes[i]}");

                cantidad = numDebilletes * billetes[i];
            }
        }
    }
}










    