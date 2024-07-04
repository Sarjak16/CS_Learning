/*

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double add = num1 + num2;
        double subtract = num1 - num2;
        double multiply = num1 * num2;

       
        double divide;
        if (num2 != 0)
        {
            divide = num1 / num2;
        }
        else
        {
            divide = double.NaN; 
        }

        Console.WriteLine("Addition: " + add);
        Console.WriteLine("Subtraction: " + subtract);
        Console.WriteLine("Multiplication: " + multiply);
        Console.WriteLine("Division: " + divide);
    }
}
*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the radius of the circle: ");
        double radius = Convert.ToDouble(Console.ReadLine());

        double area = Math.PI * radius * radius;

        Console.WriteLine("The area of the circle is: " + area);
    }
}
