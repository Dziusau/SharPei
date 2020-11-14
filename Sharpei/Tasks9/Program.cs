using System;

namespace Tasks9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 3");
            task_about_liars();
        }


        static public void task_about_liars()
        {
            Console.WriteLine("Enter how many people you would like to hear");
            int choice = Convert.ToInt32(Console.ReadLine());
            dynamic[] people = new dynamic[choice];

            people = filling_the_array(people, choice);
            for (int i = 0; i < choice; i++)
            {
                people[i].print_info_about_prev_human(people, i);
            }

            bool result = guess(people, choice);

            Console.WriteLine("Real order: ");
            for (int i = 0; i < choice; i++)
            {
                Console.WriteLine(people[i].type_of_human);
            }

            print_result(result);

        }

        static void print_result(bool result)
        {
            if (result)
            {
                Console.WriteLine("Result: Good job! Your level of intelligence is 140. Only 3% of the population has high level of " +
                    "intelligence.Such people can be seen in universities, as they are usually excellent students in all disciplines," +
                    " successfully graduate from universities, realize themselves in various professions and achieve high results.");
            }
            else
            {
                Console.WriteLine("Result: Wrong! Your level of intelligence is 40, you are an adult who can mow lawns, wash. " +
                    "About 2% of people on Earth have a level of intellectual development from 21 to 50 points," +
                    " they suffer from dementia, an average degree of mental retardation. Such people cannot learn," +
                    " but are able to take care of themselves, but most often have guardians. " +
                    "People with a severe form of mental retardation do not lend themselves to training and education.");
            }
        }

        static public dynamic[] filling_the_array(dynamic[] people, int choice)
        {
            Random rand = new Random();
            int count_of_liers = 0, count_of_fairs = 0;
            for (int i = 0; i < choice; i++)
            {
                int random_number = rand.Next(0, 2);
                if (random_number == 0)
                {
                    Liar new_liar = new Liar();
                    people[i] = new System.Dynamic.ExpandoObject();
                    people[i] = new_liar;
                    count_of_liers++;
                }
                else
                {
                    Fair new_fair = new Fair();
                    people[i] = new System.Dynamic.ExpandoObject();
                    people[i] = new_fair;
                    count_of_fairs++;
                }
            }

            Console.WriteLine($"General count of liars is {count_of_liers}, count of fairs is {count_of_fairs}");
            return people;
        }

        static public bool guess(dynamic[] people, int choice)
        {
            Console.WriteLine("\nWrite 1 if you think that liar, 2 if fair");
            bool guess_or_no = true;
            for (int i = 0; i < choice; i++)
            {
                Console.Write($"Who is {i + 1} human: ");
                int input = Convert.ToInt32(Console.ReadLine());
                string actual_type = input == 1 ? "liar" : "fair";
                if (people[i].type_of_human != actual_type)
                {
                    guess_or_no = false;
                }
            }
            return guess_or_no;

        }

        class Liar
        {
            public string type_of_human = "liar";
            public void print_info_about_prev_human(dynamic[] arr, int iterator)
            {
                if (iterator == 0)
                {
                    Console.Write("i am first and ");
                }
                else
                {
                    Console.Write("previous is ");
                    if (arr[iterator - 1].type_of_human == "liar")
                    {
                        Console.Write("fair and ");
                    }
                    else
                    {
                        Console.Write("liar and ");
                    }

                }
                if (iterator == (arr.Length - 1))
                {
                    Console.Write("i am last\n");
                }
                else
                {
                    Console.Write("next is ");

                    if (arr[iterator + 1].type_of_human == "liar")
                    {
                        Console.Write("fair\n");
                    }
                    else
                    {
                        Console.Write("liar\n");
                    }
                }
            }
        }
        class Fair
        {
            public string type_of_human = "fair";
            public void print_info_about_prev_human(dynamic[] arr, int iterator)
            {
                if (iterator == 0)
                {
                    Console.Write("i am first and ");
                }
                else
                {
                    Console.Write("previous is ");
                    Console.Write(arr[iterator - 1].type_of_human + " and ");
                }

                if (iterator == (arr.Length - 1))
                {
                    Console.Write("i am last\n");
                }
                else
                {
                    Console.Write("next is ");
                    Console.Write(arr[iterator + 1].type_of_human + "\n");
                }
            }
        }

    }
}
