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
                            Random random = new Random();
                            switch (random.Next(1, 3))
                            {
                                case 1:
                                    Circle circle = new Circle();
                                    circle.Draw();
                                    break;
                                case 2:
                                    Triangle triangle = new Triangle();
                                    triangle.Draw();
                                    break;
                                case 3:
                                    Rectangle rectangle = new Rectangle();
                                    rectangle.Draw();
                                    break;
                            }
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
abstract class Shape
{
    public abstract void Draw();
}
class Circle : Shape
{
    public override void Draw()
    {
        throw new NotImplementedException();
        Console.WindowHeight = 35;
        Console.WindowWidth = 55;
        int r = 15;
        int x = 0;
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
class Triangle : Shape 
{
    public override void Draw()
    {
        throw new NotImplementedException();
        int x1 = 20, x2 = 20;
        for (int i = 20; i > 2; i--)
        {
            Console.SetCursorPosition(x1++, i);
            Console.Write('#');
            Console.SetCursorPosition(x2--, i);
            Console.Write('#');
        }
        for (int i = 2; i < 39; i++)
        {
            Console.SetCursorPosition(i, 2);
            Console.Write('#');
        }
        Console.SetCursorPosition(20, 20);
    }
}
class Rectangle : Shape
{
    public override void Draw()
    {
        throw new NotImplementedException();
        for (int i = 0; i < 14; i++)
        {
            for (int j = 0; j < 21; j++)
               Console.Write(i == 0 || i == 13 || j == 0 || j == 20 ? '#' : ' ');
            Console.WriteLine();
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