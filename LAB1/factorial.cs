using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a non-negative integer: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number < 0)
        {
            Console.WriteLine("Factorial is not defined for negative numbers.");
        }
        else
        {
            int factorial = CalculateFactorial(number);
            Console.WriteLine("The factorial of " + number + " is: " + factorial);
        }
    }

    static int CalculateFactorial(int number)
    {
        int factorial = 1;
        for (int i = 1; i <= number; i++)
        {
            factorial *= i;
        }
        return factorial;
    }
}

