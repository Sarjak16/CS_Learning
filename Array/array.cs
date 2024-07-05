//2.WAP to input numbers in an array and find largest and second largest among them

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of elements: ");
        int n = int.parse(Console.ReadLine());

        int[] arr = new int[n];

        Console.WriteLine("Enter the elements:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.parse(Console.ReadLine());
        }

        Array.Sort(arr);

        int largest = arr[n - 1];
        int secondLargest = arr[n - 2];

        Console.WriteLine("Largest element: " + largest);
        Console.WriteLine("Second largest element: " + secondLargest);
    }
}