using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int reversed = Reverse(n);
        Console.WriteLine("Reversed number: " + reversed);
    }

    static int Reverse(int n)
    {
        int reversed = 0;
        while (n > 0)
        {
            int digit = n % 10;
            reversed = reversed * 10 + digit;
            n /= 10;
        }
        return reversed;
    }
}