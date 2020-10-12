using System;
using System.Linq.Expressions;

namespace Tasks4
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Choose task:\n1 - draw figures version 2.0\n2 - draw flags from symbols\n3 - hate this teams");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        {
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("Enter characters you want ");
                            string symbols = Console.ReadLine();
                            Flags_from_figures flag = new Flags_from_figures(symbols);
                            flag.print_flag();

                            break;
                        }
                    case "3":
                        {
                            break;
                        }
                }
            }
        }

    }
}

class Flags_from_figures
{
    public Flags_from_figures(string symbol)
    {
        this.symbol = symbol;
    }
    public Flags_from_figures() { }
    private string symbol;
    public void print_flag()
    {
        Console.Clear();
        for (int i = 0; i < 6; i++)
        {
            if (i != 2 && i != 3)
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            for (int j = 0; j < ((20 / symbol.Length) > 0 ? (20 / symbol.Length) : 1); j++)
            {
                for (int h = 0; h < symbol.Length; h++)
                {
                    if (symbol[h] != ' ')
                    {
                        Console.Write(symbol[h]);
                    }
                }
            }
            Console.WriteLine();
        }
        Console.ForegroundColor = ConsoleColor.DarkGray;
        for (int j = 0; j < 10; j++)
        {
            Console.WriteLine(symbol[0]);
        }
        Console.ResetColor();
    }
}