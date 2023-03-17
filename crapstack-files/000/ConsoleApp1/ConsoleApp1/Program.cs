using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //Console.ReadLine();

            Console.WriteLine("   /|");
            Console.WriteLine("  / |");
            Console.WriteLine(" /  |");
            Console.WriteLine("/___|");

            Console.ReadLine();

            string boobs = "boo" + "bies";

            Console.WriteLine(boobs[0].ToString().ToLower() + boobs.ToUpper());
            Console.WriteLine(boobs.Contains("boob"));
            Console.WriteLine("boob" + boobs.Substring(4));
            double ababa = Math.Pow(3.14, 3);
            Console.WriteLine(ababa);
            Console.WriteLine(Math.Max(3, 70) + '\n' + Math.Min(4, -1));
            Console.WriteLine(Math.Max(3, 70) + "\n" + Math.Min(4, -1));
            Console.WriteLine(Math.Min(45, -21));

            Console.ReadLine();
        }
    }
}
