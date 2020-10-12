using System;

namespace Tasks5
{
    class Program : Object
    {
        public virtual void Object()
        {
            Console.WriteLine("loshki");
        }


        static void Main(string[] args)
        {
            Program program = new Program();
            Akcio akcio = new Akcio();
            program.Object();
            akcio.Object();

            Console.ReadLine();
        }
    }
}
