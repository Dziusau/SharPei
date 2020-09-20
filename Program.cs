using System;

namespace SharpLearning
{
    class Program
    {
        static void GuessNumber(int number)
        {
            int left = 0, right = 99, average;
            while (true)
            {
                average = (left + right) / 2;
                if (number < average) right = average - 1;
                else if (number > average) left = average + 1;
                else
                {
                    Console.WriteLine("Guessed number: " + average);
                    break;
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number from 0 to 99");
            int guessedNumber = Convert.ToInt32(Console.ReadLine());
            GuessNumber(guessedNumber);
        }
    }
}

