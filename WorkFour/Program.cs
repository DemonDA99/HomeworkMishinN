using System;

namespace WorkFour
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;

            Console.WriteLine("Введите а: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите b: ");
            b = int.Parse(Console.ReadLine());

            c = a;
            a = b;
            b = c;

            Console.WriteLine(a);
            Console.WriteLine(b);

        }
    }
}
