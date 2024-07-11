using System;

class Program
{
    static void Check(int n)
    {
        if (n % 2 == 0)
        {
            Console.WriteLine($"{n} is even.");
        }
        else
        {
            Console.WriteLine($"{n} is odd.");
        }
    }

    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        Check(num);

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}