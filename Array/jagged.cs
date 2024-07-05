//4. find sumof elements in jagged array:
using System;

class Program

    static void Main(string[] args)
    {
        int[][] jaggedArray = new int[3][];
        jaggedArray[0] = new int[3];
        jaggedArray[1] = new int[4];
        jaggedArray[2] = new int[1];

        int sum = 0;
        for(int i=0; i<3; i++){
            for(int j=0; j<jaggedArray[i].Length; j++){
                console.WriteLine("enter numbers:");
                jaggedArray[i][j] = int.Parse(Console.ReadLine());
                sum=sum+jaggedArray[i][j];
            }
        }

        Console.WriteLine("Sum of elements : " + sum);
    }
