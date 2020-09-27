using System;
using System.Collections.Generic;


namespace ForME
{
    public class FixedStack<T>
    {
        
        T[] items;
        int count;
        const int n = 10;
        FixedStack()
        {
            items = new T[n];
        }

        FixedStack(int lenght)
        {
            items = new T[lenght];
        }

        bool IsEmpty
        {
            get
            {
                return count == 0;
            }
        }

        int Count
        {
            get
            {
                return count; 
            }
        }

        void Push(T item)
        {
            if (count == items.Length)
                throw new InvalidOperationException("Переполнение стека!");
            items[count++] = item;
        }

        T Pop()
        {
            if (IsEmpty)
                throw new InvalidOperationException("Стек пуст!");
            T item = items[count--];
            items[count] = default(T);
            return item;
        }
        
        T Peek()
        {
            return items[count-1];
        }
       
        
        static void Main(string[] args)
        {
            try
            {
                FixedStack<string> stack = new FixedStack<string>();

                stack.Push("Dasha");
                stack.Push("Sasha");
                stack.Push("Denis");

                while(stack.count>0)
                {
                    Console.WriteLine(stack.Pop());
                }
            }
            catch(InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
