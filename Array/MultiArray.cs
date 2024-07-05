//3.wap to write numbers in 2x3 array and find their sum:
using System;

class Program
{
    static void Main(string[] args)
    {
      int sum=0;
      int[,] arr = new int[2,3];
      console.WriteLine("enter 6 numbers.. ");
      for(int i=0; i<2; i++){
        for(int j=0; j<3; j++){
            a[i,j]= int.parse(console.ReadLine());
            sum= sum+a[i,j];

        }
      }
    }
}