using System;
namespace Menu
{
    class Program
    {
        static void Main(string[] args)
        {

            double a;
            Console.WriteLine("Введите А: ");
            a = Convert.ToDouble(Console.ReadLine());
            
          

            double b;
            
            Console.WriteLine("Введите B: ");
            b = Convert.ToDouble(Console.ReadLine());
            
           



       
            char c;
            double d;
           
            Console.WriteLine("Введите знак для реализации операции:");
            Console.WriteLine("(+)");
            
            c = Convert.ToChar(Console.ReadLine());
            if (c == '+')
            {
                d = a + b;
                Console.WriteLine("результат: " + d);
            }

        }
    }
}