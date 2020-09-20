using System;

namespace Draw_shape
{
    class Task_3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество сторон желаемой фигуры: ");
            int count = Convert.ToInt32(Console.ReadLine());
            Draw_shape(count);
            Console.ReadKey();

        }

        static void Draw_shape (int count)
        {
            if (count == 1)
            {
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
            if (count == 2)
            {
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
                
                }
                for (int i = 0; i < 30; i++)
                {
                    Console.SetCursorPosition(23,i);
                    Console.Write('#');
                }
                Console.SetCursorPosition(0, r * 2 + 2);
            }
            if (count == 3)
            {
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
            if (count == 4)
            {
                for (int i = 0; i < 14; i++)
                {
                    for (int j = 0; j < 21; j++)
                        Console.Write(i == 0 || i == 13 || j == 0 || j == 20 ? '#' : ' ');
                    Console.WriteLine();
                }
               
            }
        }
    }
}
