using System;

public class Program
{
    public static void Main(string[] args)
    {
        int[] nums = new int[10];
        Random rand = new Random();
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i]= rand.Next(1, 100);

            Console.WriteLine(nums[i]);
        }
    }
}