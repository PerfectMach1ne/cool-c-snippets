using System;

namespace ArrayFun
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] luckyNumbers = { 21, 7, 9, 10, 77, 39, 4146, 710, 1, 0 };

            Console.WriteLine("Evil programmers be like: Goodbye World!");
            Console.WriteLine(luckyNumbers[(int)Math.Cbrt(8.0)] + " + " + luckyNumbers[(int)Math.Log2(8)] + " = " + luckyNumbers[0]);

            string[] frens = new string[3]; // if I put 2 here, it means 2 values only - frens[0] and frens[1]
            frens[0] = "Vivi";
            frens[1] = "Silva";
            frens[2] = "oc i havent made yet";

            for (int i = 0; i < 2; i++) Console.WriteLine(frens[i]);
            Console.WriteLine(frens[2]);

            Console.ReadKey();
        }
    }
}
