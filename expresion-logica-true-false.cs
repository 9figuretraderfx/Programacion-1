using System;

class Program {
  public static void Main (string[] args) {
        Console.WriteLine("Ingrese el valor de la variable: ");
        bool var1 = Convert.ToBoolean(Console.ReadLine());
        Console.WriteLine("Ingrese el valor de la variable: ");
        bool var2 = Convert.ToBoolean(Console.ReadLine());

        bool var3 = (var1 && var1) || (var1 && var2);
        bool var4 = (var1 || var2) && (var1 || var1);
        bool var5 = !(var1 && var2);

        Console.WriteLine($"El resultado de la primera expresion logica es: {var3}");
        Console.WriteLine("El resultado de la segunda expresion logica es: " + var4);
        Console.WriteLine("El resultado de la tercera expresion logica es: " + var5);
    }
}

