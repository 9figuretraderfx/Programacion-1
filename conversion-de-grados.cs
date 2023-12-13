using System;
class Program
{
    public static void Main(String[] args)
    {
        int opcion;
        double temp; double tempConv;
        Console.WriteLine("--- MENU ---");
        Console.WriteLine("[1] F a C");
        Console.WriteLine("[2] C a F");
        Console.WriteLine("Ingrese una opcion: ");

        opcion = int.Parse(Console.ReadLine());

        if (opcion == 1) {
            Console.WriteLine("Ingrese la temperatura");
            temp = double.Parse(Console.ReadLine());
            tempConv = (temp - 32) / 1.8;
            Console.WriteLine("La onvesion de F a C es: " + tempConv);
        } else if (opcion == 2) {
            Console.WriteLine("Ingresa la temperatura: ");
            temp = double.Parse(Console.ReadLine());
            tempConv = (temp * 1.8) + 32;
            Console.WriteLine("La conversion de C a A es: " + tempConv);
        }
        else
            Console.WriteLine("Opcion invalida");
    }
}
