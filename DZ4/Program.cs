using System;

namespace DZ4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите первое число: ");
            int numberOne = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            int numberTwo = int.Parse(Console.ReadLine());

            for (int A = numberOne; A < numberTwo; A++)
            {
                Console.WriteLine(A);

            }
            Console.WriteLine(((numberOne + numberTwo) * (numberTwo - numberOne + 1)) / 2);
        }
    }
}
