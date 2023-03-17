using System;

namespace ElMethode
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHi("Luka");

            Console.ReadKey();
        }

        static void SayHi(string namae)
        {
            Console.WriteLine("Helooo " + namae + "!!!");
        }
    }
}
