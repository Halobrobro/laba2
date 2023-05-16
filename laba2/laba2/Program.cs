using System;
namespace Menu
{
    class Program
    {
        static void Main(string[] args)
        {


            double a;
            double b;
            char c;
            double d;
            Console.WriteLine("Введите А: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите B: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите знак");
            Console.WriteLine("+");
            Console.WriteLine("-");
            Console.WriteLine("*");
            Console.WriteLine("/");
            c = Convert.ToChar(Console.ReadLine());
            if (c == '+')
            {
                d = a + b;
                Console.WriteLine("результат: " + d);

            }
            if(c =='-')
            {
                d = a - b;
                Console.WriteLine("Результат: " + d);
            }
            if (c =='*')
            {
                d = a * b;
                Console.WriteLine("Результат: " + d);
            }
            if (c =='/')
            {
                d = a / b;
                Console.WriteLine("Результат: " + d);
                if (b == 0)
                {
                    Console.WriteLine("Ошибка");
                }
            }

        }
    }
}
