using System;
using System.Dynamic;

namespace ooplab1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите x:");

            double x = double.Parse(Console.ReadLine());
            double y = Math.Log(Math.Log10(Math.Exp(x))) - 0.35;

            Console.WriteLine("ln(lg(e^x))-0.35=" + y);
            Console.ReadLine();

        }
    }
}