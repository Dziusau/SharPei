using System;

namespace C_SHARP
{
    class Task_1
    {

        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            var n = Convert.ToInt32(Console.ReadLine());
            if (n < 1)
            {
                Console.WriteLine("Factorial is 1");
                return;
            }

            var factorial = 1;
            for (var i = 1; i < n + 1; ++i)
            {
                factorial = factorial * i;
            }

            Console.WriteLine($"Factorial is {factorial}");
        }
    }

}
