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
            Rainbow rainbow = new Rainbow();
            Console.WriteLine("Rainbow");
            foreach (var color in rainbow)
            {
                Console.WriteLine(color);
            }
        }
        class Rainbow
        {
            string[] colors = { "red", "orange", "yellow", "green", "light blue", "dark blue", "purple" };
            public IEnumerator<string> GetEnumerator()
            {
                return new ColorEnumerator(colors);
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
                if(position< colors.Length - 1)
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
    }
}
