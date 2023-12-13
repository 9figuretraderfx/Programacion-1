using System;
class Program
{
    public static void Main(String[] args)
    {
        int zona;
        double peso, costo;

        Console.WriteLine("Ingrese peso");
        peso = double.Parse(Console.ReadLine()) * 1000;
        if (peso > 5000)
        {
            Console.WriteLine("Limite de peso exedido");
        }
        else
        {
            Console.WriteLine("----MENU----");
            Console.WriteLine("[1] NA)");
            Console.WriteLine("[2] CA");
            Console.WriteLine("[3] SA)");
            Console.WriteLine("[4] EU");
            Console.WriteLine("[5] AS)");
            Console.WriteLine("Ingresa una opcion");
            zona = int.Parse(Console.ReadLine());

            switch (zona)
            {
                case 1:
                    costo = peso * 11;
                    Console.WriteLine("El precio de tu paquete es: " + costo);
                    break;
                case 2:
                    costo = peso * 10;
                    Console.WriteLine("El precio de tu paquete es: " + costo);
                    break;
                case 3:
                    costo = peso * 12;
                    Console.WriteLine("El costo de tu paquete es: " + costo);
                    break;
                case 4:
                    costo = peso * 24;
                    Console.WriteLine("El costo de tu paquete es: " + costo);
                    break;
                case 5:
                    costo = peso * 27;
                    Console.WriteLine("El costo de tu paqute es: " + costo);
                    break;
                default:
                    Console.WriteLine("opcion invalida");
                    break;

            }
        }
    }
}        