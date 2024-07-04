using System;

class Program
{
    static void Main()
    {
        for (int num = 100; num <= 200; num++)
        {
            if (IsPrime(num))
            {
                Console.WriteLine(num);
            }
        }
    }

    static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;

        var boundary = (int)Math.Floor(Math.Sqrt(number));

        for (int i = 3; i <= boundary; i += 2)
        {
            if (number % i == 0) return false;
        }

        return true;
    }
}