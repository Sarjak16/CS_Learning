using System;

class Program
{
    static void Main()
    {
        int[] arr = { 1, 5, 3, 4, 2 };

       
        Array.Sort(arr);

       
        foreach (int element in arr)
        {
            Console.Write(element + " ");
        }
    }
}