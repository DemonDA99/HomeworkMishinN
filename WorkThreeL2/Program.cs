using System;

namespace WorkThreeL2
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            while (true)
            {
                Console.Write("Введите число: ");
                int number = int.Parse(Console.ReadLine());

                if (number != 0)
                {
                    if (number % 2 == 0)
                    {

                    }
                    else
                    {
                        count += number;
                    }
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(count);
        }
    }
}
