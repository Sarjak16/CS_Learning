//Wap that returns maximumvalue in an array using function int max(int[])
using System;

class Program
{
    static void Main()
    {
        int[] array = { 10, 20, 30, 40, 50 };
        int maxValue = Max(array);
        Console.WriteLine("Maximum value in the array is: " + maxValue);
    }

    static int Max(int[] array)
    {
        int max = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        return max;
    }
}