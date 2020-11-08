using System;
using System.Collections;
using System.Collections.Generic;
using System.IO.Pipes;

namespace Tasks7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1\n");
            Rainbow rainbow = new Rainbow();
            Console.WriteLine("Rainbow");
            foreach (var color in rainbow)
            {
                Console.WriteLine(color);
            }

            Console.WriteLine("Task 2\nEnter country: ");
            string input = Console.ReadLine();
            Define_rainbows putin = new Define_rainbows(input);
            putin.see_rainbow();
        }
        class Rainbow
        {
            string[] colors = { "red", "orange", "yellow", "green", "light blue", "dark blue", "purple" };
            public IEnumerator<string> GetEnumerator()
            {
                return new ColorEnumerator(colors);
            }
            public void see_rainbows()
            {
                Console.Write(@"
░░░░░░░░░░░░▄▐
░░░░░░▄▄▄░░▄██▄
░░░░░▐▀█▀▌░░░░▀█▄     R    A    I    N    B    O   W     S
░░░░░▐█▄█▌░░░░░░▀█▄      D   E   T   E   C   T   E   D
░░░░░░▀▄▀░░░▄▄▄▄▄▀▀    
░░░░▄▄▄██▀▀▀▀
░░░█▀▄▄▄█░▀▀           R     U     S     S     I     A
░░░▌░▄▄▄▐▌▀▀▀          ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("##########################");
                Console.ResetColor();
                Console.Write(@"
▄░▐░░░▄▄░█░▀▀          ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("##########################");
                Console.ResetColor();
                Console.Write(@"
▀█▌░░░▄░▀█▀░▀          ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("##########################");
                Console.ResetColor();
                Console.Write(@"
░░░░░░░▄▄▐▌▄▄          ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("##########################");
                Console.ResetColor();
                Console.Write(@"
░░░░░░░▀███▀█░▄        ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("##########################");
                Console.ResetColor();
                Console.Write(@"
░░░░░░▐▌▀▄▀▄▀▐▄        ");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write("##########################");
                Console.ResetColor();
                Console.Write(@"
░░░░░░▐▀░░░░░░▐▌       ");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write("##########################");
                Console.ResetColor();
                Console.Write(@"
░░░░░░█░░░░░░░░█    
░░░░░▐▌░░░░░░░░░█    
░░░░░█░░░░░░░░░░▐▌");

            }
        }
        class ColorEnumerator : IEnumerator<string>
        {
            string[] colors;
            int position = -1;

            public ColorEnumerator(string[] colors)
            {
                this.colors = colors;
            }
            public string Current
            {
                get
                {
                    if (position == -1 || position >= colors.Length)
                        throw new InvalidOperationException();
                    return colors[position];
                }
            }
            object IEnumerator.Current => throw new NotImplementedException();

            public void Dispose() { }

            public bool MoveNext()
            {
                if (position < colors.Length - 1)
                {
                    position++;
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public void Reset()
            {
                position = -1;
            }
        }

        class Define_rainbows
        {
            private Rainbow[] rainbow = new Rainbow[5];
            private string country;
            public Define_rainbows(string country)
            {
                this.country = country;
                if ((country == "Russia") || (country == "russia"))
                {
                    for (int i = 0; i < 5; i++)
                    {
                        rainbow[i] = new Rainbow();
                    }
                }
            }
            public void see_rainbow()
            {
                try
                {
                    rainbow[0].see_rainbows();
                }
                catch (NullReferenceException)
                {
                    Console.WriteLine(@"
_________________8#88111111111____________________
____________1#####81111__1111111818_______________
_________1#####888881111______118#####8___________
_______#########811____________18#8######_________     
_____####88811181111_____1_________88#818#1_______                     N     O
____####_________11_____________________11________
__1###8_________________________________1_1__1____         R    A   I   N   B   O   W    S
_8###8__________________________________118888#___             
_###8___________________________________1188####__           D   E   T   E   C   T   E   D
####811__________________________________18#####__
####811__________________________________18#####__
###8111_________________________________18#######_
####1111_______________________________11########_
###88111________________________________8#######8_        
###88111_______________________________1_8######8#
###88811_1____________________________11_8######8#                
###818###########1111188#########8__111___######18
_1#118#############88###############81____8#####18
_11111188181#####1#81###8811###88##11_____1#1881__
__811__11881188188#1_##81181___1__________181__#__
__1181____18881_1_81_1#_1_8818811_______111##8____
____#881_________#1___8________________1111_______
____8#8811______#1_____11__________11118111_______
_____#8881_____188____1__8______11111888111_______
_____##8811____1#8______18_____11888888#818_______
_____8###811____8########1_____118##888881________
______####811_111######11_______8888888888________
_______#######88111##888888##88888#8##8##_##______
________##########################8######_####____
__1#########88###818818####888#8##8#####__######8_
#########8###818###88##8811818#########___########
########___###81111111__11188########_____########
#######_____#######################______#########
######_______###################8_______##########
#####__________###############_________###########");
                }
            }
        }
    }
}

