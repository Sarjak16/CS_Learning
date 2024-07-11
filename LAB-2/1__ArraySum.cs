using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the size of the array: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[n];

        Console.WriteLine("Enter " + n + " numbers:");
        for (int i = 0; i < n; i++)
        {
            Console.Write("Number " + (i + 1) + ": ");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += array[i];
        }

       Console.WriteLine("The sum of the array is: " + sum);
    }
}