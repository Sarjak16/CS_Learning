using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a letter: ");
        char letter = Console.ReadLine()[0];

        if (char.IsLetter(letter))
        {
            letter = char.ToLower(letter); // convert to lowercase for simplicity

            if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
            {
                Console.WriteLine("The letter is a vowel.");
            }
            else
            {
                Console.WriteLine("The letter is a consonant.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a letter.");
        }
    }
}