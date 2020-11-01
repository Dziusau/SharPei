using System;
using System.Collections.Generic;
using System.Globalization;

namespace Tasks6
{
    class Program
    {
        static void Main(string[] args)
        {
            Money money = new Money();
            money.AddNotifier(sendSMS);

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
            //task about dates
             time_to_death();

        }

        static public void sendSMS(string message)
        {
            Console.WriteLine(message);
        }
        
         public static void time_to_death()
        {
            var time_birth = new DateTime();
            var time_death = new DateTime();
            bool identify = true;
            while (true)
            {
                   Console.WriteLine("Choose character you want?\n1 - Hitler\n2 - Putin\n3 - You\n4 - SpongeBob");
                   string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        {
                            time_birth = new DateTime(1889, 4, 20, 6, 6, 6);
                            time_death = new DateTime(1945, 4, 30, 15, 12, 30);
                            break;
                        }
                    case "2":
                        {
                            time_birth = new DateTime(1952, 10, 7, 0, 0, 0);
                            time_death = new DateTime(9999, 12, 30, 23, 59, 59);
                            break;
                        }
                    case "3":
                        {
                            time_birth = new DateTime(1998, 1, 27, 22, 10, 5);
                            Random random = new Random();
                            time_death = new DateTime(random.Next(2000, 2120), random.Next(1, 12), random.Next(1, 29), random.Next(1, 59), random.Next(1, 59), random.Next(1, 59));
                            break;
                        }
                    case "4":
                        {
                            time_birth = new DateTime(1986, 7, 14, 0, 0, 0);
                            time_death = new DateTime(2018, 11, 27, 23, 59, 3);
                            break;
                        }
                  default:
                        {
                            return;
                        }

                }

                try
                {
                    Console.Write($"Enter date in the format dd%MM^yyyy to know information: ");
                    string input = Console.ReadLine();
                    var deff = DateTime.ParseExact(input, @"dd\%MM^yyyy", CultureInfo.InvariantCulture);
                    var difference = DateTime.MinValue + (DateTime.ParseExact(input, @"dd\%MM^yyyy", CultureInfo.InvariantCulture) - time_birth);
                    Console.WriteLine($"From birth:{difference.Year - 1} years, {difference.Month - 1} monthes, {difference.Day - 1} days, {difference.Hour} hours," +
                        $" {difference.Minute} minutes, {difference.Second} seconds");

                    if(DateTime.ParseExact(input, @"dd\%MM^yyyy", CultureInfo.InvariantCulture) > time_death)
                    {
                        if (choice == "1") { Console.WriteLine("Officially he died, but in fact he was replaced by a clone, and then he hid in a corn field for 25 years, " +
                            "until people forgot who he was, and then he moved to Belarus, the further fate is unknown ......."); }
                        else if (choice == "2") { Console.WriteLine("He will never die, and even if he dies, he will be replaced by clones"); }
                        else if (choice == "3") { Console.WriteLine("You are actually dead, sorry bro... (>^_^)> <(^_^<)"); }
                        else if (choice == "4") { Console.WriteLine("It's hard for me to say this, but the spongebob is already dead"); }
                    }
                    else
                    {
                        if (choice == "1")
                        {
                            Console.WriteLine("Hitler is alive");
                            var year = time_death.Year - deff.Year;
                            var month = time_death.Month - deff.Month;
                            if ((time_death.Month - deff.Month) < 0) { year--; month = 12 - Math.Abs(time_death.Month - deff.Month); }
                            Console.WriteLine($"He will die in {time_death}, time left to live {year} years, {month} monthes, " +
                                $"{time_death.Day - deff.Day} days,  {time_death.Minute - deff.Minute} minutes,  {time_death.Second - deff.Second} seconds");
                        }
                        else if (choice == "2")
                        {
                            Console.WriteLine("He will never die, and even if he dies, he will be replaced by clones");
                        }
                        else if (choice == "3")
                        {
                            Console.WriteLine("You are alive, but for how long");
                            var year = time_death.Year - deff.Year;
                            var month = time_death.Month - deff.Month;
                            if ((time_death.Month - deff.Month) < 0) { year--; month = 12 - Math.Abs(time_death.Month - deff.Month); }
                            Console.WriteLine($"You will die in {time_death}, time left to live {year} years, {month} monthes, " +
                                $"{time_death.Day - deff.Day} days,  {time_death.Minute - deff.Minute} minutes,  {time_death.Second - deff.Second} seconds");
                        }
                        else if (choice == "4")
                        {
                            Console.WriteLine("SpongeBob is alive");
                            var year = time_death.Year - deff.Year;
                            var month = time_death.Month - deff.Month;
                            if ((time_death.Month - deff.Month) < 0) { year--; month = 12 - Math.Abs(time_death.Month - deff.Month); }
                            Console.WriteLine($"SpongeBob will die in {time_death}, time left to live {year} years, {month} monthes, " +
                                $"{time_death.Day - deff.Day} days,  {time_death.Minute - deff.Minute} minutes,  {time_death.Second - deff.Second} seconds");
                        }
                    }
                }
                catch (FormatException)
                {
                    if (identify)
                    {
                        Console.WriteLine("enter a normal date in the suggested format");
                    }
                    else
                    {
                        Console.WriteLine("I AM NORMALLY IN RUSSIAN IN ENGLISH ASKED TO INPUT BY HANDS AND NOT AN ASS");
                    }
                    identify = false;
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("sorry he didn't exist at such an early time");
                }
            }
        }
    }
}
