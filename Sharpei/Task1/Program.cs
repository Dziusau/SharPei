using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Fibonachi.Start();
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
