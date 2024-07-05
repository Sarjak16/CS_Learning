//1.WAP to input 10numbers in array and find their sum:
using System;

class Program
{
    static void Main()
    {
        int[] arr = new int[10];
        int sum = 0;

        // Input 10 numbers
        Console.WriteLine("Enter 10 numbers:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write("Number {0}: ", i + 1);
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Calculate the sum
        for (int i = 0; i < 10; i++)
        {
            sum += arr[i];
        }

        // Print the sum
        Console.WriteLine("The sum of the 10 numbers is: " + sum);
    }
}