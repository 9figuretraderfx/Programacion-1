using System;

public class Program
{
    public static void Main(string[] args)
    {
        void ArregloTabla()
        {
            Console.WriteLine("Ingresa el numero de la tabla que deseas calcular");
            int tabla = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("La tabla de multiplicar al reves es: ");
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(tabla + " * " + i + " = " + tabla * i);
            }
        }
        ArregloTabla();
    }
} 