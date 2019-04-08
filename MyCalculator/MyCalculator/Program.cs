using MyCalculator.Core;
using System;

namespace MyCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            ICore core = new Core.Core();

            int x = 2, y = 2;
            Console.WriteLine($"{x} + {y} = {core.Add(x, y)}");
            Console.WriteLine($"{x} - {y} = {core.Sub(x, y)}");
            Console.ReadKey();
        }
    }
}
