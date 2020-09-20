using System;
using System.Threading;

namespace Fibonachi
{
    class Program
    {
        /*Функция нахождение чисел Фибоначчи, принимает, как аргумент, единственное целое число n - номер элемента
          последовательности, который необходимо найти. Чи́сла Фибона́ччи — элементы числовой последовательности в которой 
          первые два числа равны 0 и 1 (в данном случае), а каждое последующее число равно сумме двух предыдущих чисел.*/
        static ulong fibonachi(int n)
        {
            if (n == 1 || n == 2)
            {
                return 1;
            }
            else if (n > 1)
            {
                int i = 0;
                ulong result = 0, fib_1 = 1, fib_2 = 1;
                while (i < n - 2)
                {
                    result = fib_1 + fib_2;
                    fib_1 = fib_2;
                    fib_2 = result;
                    i++;
                }
                return result;
            }
            return 0;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Выберите действие:\n1 - нахождение числа Фибоначчи по номеру элемента\n2 - вывод ряда Фибоначчи на экран до n-ого значения");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    {
                        Console.WriteLine("Введите число: ");
                        int input = Convert.ToInt32(Console.ReadLine());
                        //обычный вывод, если вы не любите смайлики: Console.WriteLine("Число Фибоначчи для " + input + " = " + fibonachi(input));
                        Console.WriteLine("число_    _    _"+fibonachi(input)+"\n      |_(o_o)_|\n    \t  |\n    \t _|_\n     \t|   |\n     \t|   |\nявляется-   - числом Фибоначчи для "+input);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Введите число элементов, которые хотите вывести: ");
                        int input = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Ряд Фибоначчи для "+input+": ");
                        for (int i = 0; i < input; i++)
                        {
                            Console.Write(fibonachi(i) + " ");
                        }
                        break;
                    }
            }
           
        }
    }
}
