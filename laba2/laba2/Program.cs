using System;
namespace Menu
{
    class Program
    {
        static void Main(string[] args)
        {

            double a, b;
            char c;
            double d;
            Console.WriteLine("Введите А: ");
            a = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Введите B: ");
            b = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Введите знак для реализации операции:");
            Console.WriteLine("(+)");
            Console.WriteLine("(-)");
            Console.WriteLine("(*)");
            Console.WriteLine("(/)");
            c = Convert.ToChar(Console.ReadLine());
        }
    }
}