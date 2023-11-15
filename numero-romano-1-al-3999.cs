using System;

public class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            string[] units = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            string[] decs = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] cents = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string[] mils = { "", "M", "MM", "MMM" };

            var value = Console.ReadLine();
            if (string.IsNullOrEmpty(value))
                return;

            var n = int.Parse(value);
            if (n <= 0 || n >= 3999)
            {
                Console.WriteLine("Valor no permitido");
                return;
            }

            int m = n / 1000;
            int resto = n % 1000;
            int c = resto / 100;
            resto = resto % 100;
            int d = resto / 10;
            resto = resto % 10;
            int u = resto;

            Console.WriteLine(mils.ElementAtOrDefault(m) + cents.ElementAtOrDefault(c) + decs.ElementAtOrDefault(d) + units.ElementAtOrDefault(u));
  
        }
    }
}

