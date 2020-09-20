using System;

namespace C_SHARP
{
    class Program
    {

        static void Main(string[] args)
        {
            int n;
            int factorial = 1;
            Console.Write("Enter n: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < n + 1; ++i)
            {
                if (n == 0)
                {
                    Console.Write(1);
                    break;
                }
                    
                factorial = factorial * i;
            }
            string fact = factorial.ToString();
            Console.Write("Factorial is ");
            Console.WriteLine(fact);
        }
    }

}
