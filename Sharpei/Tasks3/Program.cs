using System;
using System.Collections.Generic;

namespace Tasks3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите задание\n1 - Класс, который считает, сколько объектов этого класса было создано.\n2 - Сейф для переменной\n3 - Класс уточка");
            string cho = Console.ReadLine();
            switch (cho)
            {
                case "1":
                    { 
                        break;
                    }
                case "2":
                    {   
                        Console.WriteLine("Введите значение переменной");
                        Black_Box<int> black_Box = new Black_Box<int>(Console.ReadLine());
                        Console.WriteLine($"Значение переменной: {black_Box.Variable}");
                        break;
                    }
                case "3":
                    {
                        List<Duck> ducks = new List<Duck>();
                        ducks.Add(new Wild_duck());
                        ducks.Add(new Home_duck());
                        ducks.Add(new Gray_duck());
                        ducks.Add(new Black_duck());
                        ducks.Add(new Autistic_duck());
                        ducks.Add(new Rubber_duck());
                        ducks.Add(new Loving_duck());
                        ducks.Add(new Donald_duck());
                        ducks.Add(new Crazy_duck());
                        ducks.Add(new Strange_duck());

                        Random rand = new Random();
                        while (true)
                        {
                            Console.WriteLine("Нажмите что-нибудь, чтобы услышать уточку, 1 - выход");
                            string choice = Console.ReadLine();
                            if (choice == "1")
                            {
                                return;
                            }
                            else
                            {
                                int number = rand.Next(0, 10);
                                ducks[number].quack();
                            }
                        }
                    }
                    }
            }
           
    }

    class Black_Box<T>
    {
        private T variable;

        public T Variable 
        {
            set 
            {
                variable = value;   
            }
            get 
            {
                return variable;
            } 
        }

	    public Black_Box(T value)
        {
            Variable = value;
        }
    }
 
    interface quackle
    {
        public void quack();
    }

    class Duck : quackle
    {
        public virtual void quack(){}
    }

    class Wild_duck : Duck
    {
        public override void quack()
        {
            Console.WriteLine("Я хожу на пары в субботу!");
        }
    }

    class Home_duck : Duck
    {
        public override void quack()
        {
            Console.WriteLine("Я всегда сижу дома!");
        }
    }

    class Gray_duck : Duck
    {
        public override void quack()
        {
            Console.WriteLine("Я люблю хлеб и купаться!");
        }
    }

    class Black_duck : Duck
    {
        public override void quack()
        {
            Console.WriteLine("Я люблю рэп и играть в баскетбол!");
        }
    }

    class Autistic_duck : Duck
    {
        public override void quack()
        {
            Console.WriteLine("Паскаль-АВС мой любимый язык программирования!");
        }
    }

    class Rubber_duck : Duck
    {
        public override void quack()
        {
            Console.WriteLine("Я люблю, когда со мной купаются!");
        }
    }

    class Loving_duck : Duck
    {
        private String team;
        private void find_favorite_team()
        {
            Random rand = new Random();
            int number = rand.Next(1, 5);
            if(number == 1)
            {
                team = "Ёжики";
            }
            else if (number == 2)
            {
                team = "Ретиколо";
            }
            else if (number == 3)
            {
                team = "Решеточки";
            }
            else if (number == 4)
            {
                team = "Акцио";
            }
            else if (number == 5)
            {
                team = "Ъеъ";
            }
        }
        public override void quack()
        {
            find_favorite_team();
            Console.WriteLine("Я люблю команду "+team);
        }
    }

    class Donald_duck : Duck
    {
        public override void quack()
        {
            Console.WriteLine("Голосуйте за Трампа!");
        }
    }

    class Crazy_duck : Duck
    {
        public override void quack()
        {
            Console.WriteLine("Я использую goto!");
        }
    }

    class Strange_duck : Duck
    {
        public override void quack()
        {
            Console.WriteLine("Я программирую на java!");
        }
    }
}
