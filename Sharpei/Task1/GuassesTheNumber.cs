using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class GuassesTheNumber
    {
        public  static void GuessNumber(int number)
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
        public static void Start()
        {
            Console.WriteLine("Enter number from 0 to 99");
            int guessedNumber = Convert.ToInt32(Console.ReadLine());
            GuessNumber(guessedNumber);
        }
    }
}
