using System;

namespace WorkTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int height;
            int weight;

            Console.WriteLine("введите рост в метрах: ");
            height = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите вес в килограммах: ");
            weight = int.Parse(Console.ReadLine());

            int L = (height * height) / weight;
            Console.WriteLine(L);
            Console.ReadKey();
        }
    }
}
