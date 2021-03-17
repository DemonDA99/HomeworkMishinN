using System;

namespace WorkOneL2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Введите третье число: ");
            int c = int.Parse(Console.ReadLine());

            if (a < b && a < c)
            {
                Console.WriteLine(a);
            }
            else
            {
                if(b < a && b < c)
                {
                    Console.WriteLine(b);
                }
                else
                {
                    if(c < a && c < b)
                    {
                        Console.WriteLine(c);
                    }
                }
            }
        }
    }
}
