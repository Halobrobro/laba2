using System;
namespace Menu
{
    class Program
    {
        static void Main(string[] args)
        {

            
            char c;
            double d;
           
            
            Console.WriteLine("Введите знак для реализации операции:");
            
            Console.WriteLine("(*)");
            
            c = Convert.ToChar(Console.ReadLine());
            if (c =='*')
            {
                d = a * b;
                Console.WriteLine("Результат: " + d);
            }
        }
    }
}