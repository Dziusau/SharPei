using System;

namespace Tasks6
{
    class Program
    {
        static void Main(string[] args)
        {
            Money money = new Money();
            while (true)
            {

                Console.WriteLine(" 1. Balance\n 2. Diposit\n 3. Take off\n 4. Exit\n\n5. Task 6/2: Find unique words");
                int k = Convert.ToInt32(Console.ReadLine());
                switch (k)
                {
                    case 1:
                        Console.WriteLine("Balance:");
                        money.balace();
                        break;
                    case 2:
                        Console.WriteLine("Diposit:");
                        money.diposit();
                        break;
                    case 3:
                        Console.WriteLine("Take off:");
                        money.take_off();
                        break;
                    case 4:
                        return;                
                    case 5:
                        {
                        Console.WriteLine("Enter string: ");
                        List<string> unique = UniqueWords.GetUniqueWords(Console.ReadLine());
                        Console.WriteLine("Unique words: ");
                        foreach (string word in unique)
                        {
                           Console.WriteLine(word);
                        }
                        break;
                        }
                }

            }
        }
    }
}
