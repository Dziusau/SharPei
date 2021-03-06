﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks2
{
    class Stack
    {
        public static void Start()
        {
            Stack<int> numbers = new Stack<int>();

            numbers.Push(32);
            numbers.Push(15);
            numbers.Push(43);

            Console.WriteLine("Sourse stack: ");
            while (numbers.Count > 0)
            {
                Console.WriteLine(numbers.Pop());
            }

            if (numbers.Count == 0)
            {
                Console.WriteLine("Stack is empty( ");
            }

            Queue<string> people = new Queue<string>();

            people.Enqueue("Dasha");
            people.Enqueue("Sasha");
            people.Enqueue("Denis");

            while (people.Count > 0)
            {
                Console.WriteLine(people.Dequeue());
            }


            Console.ReadLine();
        }
    }
}
