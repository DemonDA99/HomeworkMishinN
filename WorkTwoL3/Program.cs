using System;

namespace WorkTwoL3
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            while (true)
            {
                Console.Write("Введите число: ");
                int number;
    
                bool TrFo = int.TryParse(Console.ReadLine(), out number);

                if (TrFo)
                {
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
                else
                {
                    Console.WriteLine("Некорректные данные!");
                    break;                }
                Console.WriteLine(count);
            }
        }
    }
}
