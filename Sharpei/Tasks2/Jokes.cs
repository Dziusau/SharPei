using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.IO;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Tasks2
{
    class Jokes
    {
       public static void Start()
       {
            string path = @"..\..\..\test.txt";
            while (true)
            {
                Console.WriteLine("Введите что-нибудь, чтобы увидеть анекдот или 0, для выхода..");
                if (Console.ReadLine() == "0")
                {
                    Console.WriteLine("ну всё_    _    _                       \n      | _(т.т)_ |\n    \t   |\n    \t  _|_\n     \t |   |\n     \t |   |\n        -    - пока.....");
                    return;
                }
                Console.Clear();
                Console.WriteLine(random_anecdote_from_file(path, 30));
            }
        }

        static string random_anecdote_from_file(string path, int number_of_anecdotes = 100)
        {
            StreamReader read = new StreamReader(path, System.Text.Encoding.Default);
            string line;
            string[] array = new string[number_of_anecdotes];
            for (int i = 0; i < number_of_anecdotes; i++)
            {
                if ((line = read.ReadLine()) != null)
                {
                    array[i] = line;
                }
                else
                {
                    break;
                }
            }
            Random x = new Random();
            return array[x.Next(0, number_of_anecdotes)];
        }
    }
}
