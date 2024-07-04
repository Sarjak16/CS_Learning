using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a non-negative integer: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number < 0)
        {
            Console.WriteLine("Invalid input. Please enter a non-negative integer.");
        }
        else
        {
            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}