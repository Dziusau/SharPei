using System;
using System.Text.RegularExpressions;
using System.Threading;

namespace Tasks5
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Choose task: 1 - library, 2 - namespaces, 3 - error in figures");
                switch (Console.ReadLine())
                {
                    case "1":
                        {
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("Choose namespace: 1 - normal, 2 - not normal");
                            string choose_namespace = Console.ReadLine();
                            if (choose_namespace == "1")
                            {
                                SuperProgrammer.IQ_Test member = new SuperProgrammer.IQ_Test();
                                member.test_your_IQ();
                            }
                            else if (choose_namespace == "2")
                            {
                                StupidProgrammer.IQ_Test member = new StupidProgrammer.IQ_Test();
                                member.test_your_IQ();
                            }
                            break;
                        }
                    case "3":
                        {
                            Figure figure;
                            Circle circle = new Circle();
                            figure = circle.Draw;
                            Console.WriteLine("Choose figure:\n1 - raund\n2 - triangle\n3 - rectangle");
                            switch (Console.ReadLine())
                            {
                                case "1":
                                    {
                                        break;
                                    }
                                case "2":
                                    {
                                        Triangle triangle = new Triangle(); 
                                        figure = triangle.Draw;
                                        break;
                                    }
                                case "3":
                                    {
                                        Square square = new Square();
                                        figure = square.Draw;
                                        break;
                                    }
                            }
                            try
                            {
                                Console.WriteLine("Enter side: ");
                                int x = Convert.ToInt32(Console.ReadLine());
                                figure(x);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"Exception: {ex.Message}");
                            }
                            break;
                        }
                }
            }
        }
        delegate void Figure(int x);
    }
    class Circle
    {
        public void Draw(int r)
        {
            if (r <= 0)
            {
                throw new Exception("Radius must be > 0");
            }
            else
            {
                Console.WindowHeight = 35;
                Console.WindowWidth = 55;
                int x;
                for (int y = 0; y < r; ++y)
                {
                    x = (int)Math.Round(2 * Math.Sqrt((Math.Pow(r, 2) - Math.Pow(y, 2))));
                    Console.SetCursorPosition(x + r, y + r);
                    Console.Write('#');
                    Console.SetCursorPosition(x + r, -y + r);
                    Console.Write('#');
                    Console.SetCursorPosition(-x + 2 * r, -y + r);
                    Console.Write('#');
                    Console.SetCursorPosition(-x + 2 * r, y + r);
                    Console.Write('#');
                }
                Console.SetCursorPosition(0, r * 2 + 2);
            }
        }
    }
    class Triangle
    {
        public void Draw(int side)
        {
            if (side <= 0)
            {
                throw new Exception("Side must be > 0");
            }
            else
            {
                int x1 = 20, x2 = 20;
                for (int i = 20; i > 20 - side * 1.71 / 2; i--)
                {
                    Console.SetCursorPosition(x1++, i);
                    Console.Write('#');
                    Console.SetCursorPosition(x2--, i);
                    Console.Write('#');
                }
                for (int i = (int)(20 - side * 1.71 / 2); i < side; i++)
                {
                    Console.SetCursorPosition(i, 2);
                    Console.Write('#');
                }
                Console.SetCursorPosition(20, 20);
            }
        }
    }
    class Square
    {
        public void Draw(int side)
        {
            if (side <= 0)
            {
                throw new Exception("Side must be > 0");
            }
            else
            {
                for (int i = 0; i < side; i++)
                {
                    for (int j = 0; j < side; j++)
                        Console.Write(i == 0 || i == (side - 1) || j == 0 || j == (side - 1) ? '#' : ' ');
                    Console.WriteLine();
                }
            }
        }
    }
    namespace SuperProgrammer
    {
        class IQ_Test
        {
            public int IQ { get => IQ; set => IQ = value; }
            private string name; 
            private void setName (string name)
            {
                Regex regex = new Regex(@"^[A-Z]?[a-z]*$");
                this.name = regex.IsMatch(name) ? name : "man without name";
            }

            public void test_your_IQ()
            {
                int result = 0;
                Console.WriteLine("Hi, I suggest you take an IQ test, enter 1 to start and anything else to start");
                string choice = Console.ReadLine();
                result += get_score(choice, "1");
                Console.Clear();

                Console.WriteLine("Do you think the test has not started yet? You're wrong. What is your name?");
                string yourName = Console.ReadLine();
                setName (yourName);
                result+= (name == "man without name") ? -10 : 10;
                Console.Clear();

                Console.WriteLine($"Hi, {name}. Now you will have to choose the correct answer, to select enter numbers from 1 to 5. First question:");
                Console.WriteLine("The chess set cost $ 1200. After the price reduction, it began to cost 1080 rubles. By what percentage has the price of cheese been reduced?\n1 - 15%\n2 - 10%\n3 - 88.4%\n4 - what? cheese?\n5 - i like cheese");
                choice = Console.ReadLine();
                result += get_score(choice, "4");
                Console.Clear();

                Console.WriteLine("Second question: how old is the planet earth?\n1 - 4.5 billion years\n2 - 6.0 millions years\n3 - 2020 years\n4 - 7 minutes\n5 - 3.8 billions years\n6 - 0 years"); 
                choice = Console.ReadLine();
                result += get_score(choice, "1");
                Console.Clear();

                Console.WriteLine("Third question: choose red");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("blue - 1");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("green - 2");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("red - 3");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("black - 4");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("eight - 5");
                choice = Console.ReadLine();
                result += get_score(choice, "3");
                Console.Clear();

                Console.WriteLine("Fifth question: does it exist 29 of february in Australia?\n1 - no\n2 - maybe\n3 - i don't know\n4 - probably yes\n5 - probably no\n6 - yes");
                choice = Console.ReadLine();
                result += get_score(choice, "4");
                Console.Clear();

                Console.WriteLine("Sixth question: Vladimir is successfully studying in college, in his free time he works as a courier. He is a caring son and loyal friend. All this characterizes Oleg as ...\n1 - personality\n2 - caring person\n3 - who is it?\n4 - individual\n5 - law abiding citizen");
                choice = Console.ReadLine();
                result += get_score(choice, "3");
                Console.Clear();

                Console.WriteLine("Next question: what color is the skin of a zebra?\n1 - white\n2 - black\n3 - striped\n4 - who is zebra?\n5 - pink");
                choice = Console.ReadLine();
                result += get_score(choice, "2");
                Console.Clear();

                Console.WriteLine("How many questions have I already asked? (include this question)");
                choice = Console.ReadLine();
                result += get_score(choice, "9", "7");
                Console.WriteLine("Test is over, please wait result");
                simulated_delay();
                Console.Clear();

                get_result(result, yourName);
                IQ_result(result);
            }
            private int get_score(String actual, String expected1, String expected2 = "0")
            {
                return actual==expected1 ? 10 : actual == expected2 ? 5 : -10;
            }
            private void simulated_delay()
            {
                for (int i = 1; i < 6; i++)
                {
                    Thread.Sleep(1000);
                    Console.Write(i + "..");
                }
            }
            private void IQ_result(int result)
            {
                int iq = (int)((result + 90)*1.6);
                Console.WriteLine("Your IQ is "+iq);
            }
            private void get_result(int result, String yourName)
            {
                if (result == -90)
                {
                    Console.WriteLine($"You are very dumb, I advise you to see a doctor. You didn't even enter your name correctly ... Or is your real name {yourName}? In your case, nothing will help you.");
                }
                else if (result > -90 && result < -40)
                {
                    Console.WriteLine("You're dumb, but you have a chance to change that. Here is the link - https://lifehacker.ru/10-ways-to-be-smart/");
                }
                else if (result <= 0 && result >= -40)
                {
                    Console.WriteLine("You are a little dumb, but you don't have to worry about it, maybe you are 7 years old. Try reading books.");
                }
                else if (result <= 50 && result > 0)
                {
                    Console.WriteLine("You are average, you can be proud of it. Make an effort and you will become smart.");
                }
                else if (result > 50 && result < 90)
                {
                    Console.WriteLine("Wow, you're very smart. Share your test results with everyone, because it's worthy of respect.");
                }
                else if (result == 90)
                {
                    Console.WriteLine("You are an incredible genius. You are most likely the only one in the world. If you see this message, they have already left for you!");
                }
            }

        }
    }

    namespace StupidProgrammer
    {
        class IQ_Test
        {
            public void test_your_IQ()
            {
                Console.WriteLine("Enter your IQ: ");
                int iq = Convert.ToInt32(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine("Your IQ is "+ iq);
            }
        }
    }
}
