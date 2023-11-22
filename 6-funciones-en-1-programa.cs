using System;

public class Program
{
    public static void Main(string[] args)
    {
        int[] numerosenteros = new int[10];


        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Ingresa un numero");
            numerosenteros[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("\n" + numerosenteros[i]);


        }
        int suma = 0;
        for (int j = 0; j < 10; j++)
        {
            suma = suma + numerosenteros[j];
        }
        Console.WriteLine("La suma de los numeros es: " + suma);

        int n;
        Console.WriteLine("Digite la cantidad de numeros: ");
        n = int.Parse(Console.ReadLine());
        int[] vector = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Numero {0}: ", (i + 1));
            vector[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                int aux;
                if (vector[i] > vector[j])
                {
                    aux = vector[i];
                    vector[i] = vector[j];
                    vector[j] = aux;
                }
            }
        }
        Console.WriteLine("Datos ordenados");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(vector[i]);
        }
        Console.ReadKey();

        MostrarMenu();

        do
        {
            Arreglolista();
            Console.WriteLine("Desea volver a consultar la posicion de un numero? (S/N)");
        }
        while (Console.ReadLine().ToLower() == "s");
    }

    static void MostrarMenu()
    {
        int[] menunumeros = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        Console.WriteLine("--------MENU--------");
        foreach (var numero in menunumeros)
        {
            Console.WriteLine(numero);
        }
    }

    static void Arreglolista()
    {
        Console.WriteLine("Ingrese un numero de la lista");
        int numeroNum = Console.ReadLine()[0];

        int[] menunumeros = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int position = Array.IndexOf(menunumeros, numeroNum);
        if (position != -1)
        {
            Console.WriteLine($"{numeroNum} esta en la posicion {position + 1} de la lista");
        }
        else
        {
            Console.WriteLine($"{numeroNum} no se encuentra en la lista");
        }
    }
}
