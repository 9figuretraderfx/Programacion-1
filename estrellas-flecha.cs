using System;

public class Program
{
    public static void Main(string[] args)
    {
        int i, j;
        for (i = 1; i <= 5; i++)
        {
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        for (i = 4; i >= 1; i--)
        {
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}