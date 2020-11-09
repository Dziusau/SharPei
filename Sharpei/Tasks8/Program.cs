using System;
using System.Threading;
using System.Threading.Tasks;

namespace Tasks8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1");
            Competitions first = new Competitions();
            first.competition();
            //if it doesn't work add some zeros
            Thread.Sleep(1000);
        }
    }


    public class Competitions
    {
        public static bool first = false;
        private static int expected;

        public void competition()
        {
            Console.WriteLine("I suggest you bet 50$ to: 1 - 97, 2 - 3, 3 - 18");
            string choice = Console.ReadLine();
            Console.WriteLine("bets accepted!");
            if (choice == "1")
            {
                expected = 97;
            }
            else if (choice == "2")
            {
                expected = 3;
            }
            else
            {
                expected = 0;
            }

            run(97);
            run(3);
        }

        static async void run(int number)
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 50; i++)
                {
                    Console.WriteLine($"number {i} is {number}");
                    if (first) { break; }
                }

                if (!first)
                {
                    first = true;
                    result(number);
                }

            });
        }

        static void result(int n)
        {
            if (expected == n)
            {
                Console.WriteLine($"You won! {n} was first! To collect your winnings, call 8 017 289-80-48 and explain the whole situation");
            }
            else
            {
                Console.WriteLine($"Unfortunately {n} was first. You have lost all your money. Collectors will come to you soon ;)");
            }
        }
    }
}
