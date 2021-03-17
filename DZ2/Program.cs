using System;

namespace DZ2
{
    class Program
    {
        static void Main(string[] args)
        {
            double height;
            double weight;
           

            Console.WriteLine("Введите Ваш рост(пример 1,82): ");
            height = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите Ваш вес: ");
            weight = double.Parse(Console.ReadLine());
            
            double result = weight / (height * height);
            if(result >= 18 && result <= 25)
            {
                Console.WriteLine("Ваш ИМТ: " + "{0:0.00}",result);
                Console.WriteLine("Ваш вес в норме");
            }
            if(result >= 26)
            {
                Console.WriteLine("Ваш ИМТ: " + "{0:0.00}",result);
                Console.WriteLine("Вам следует похудеть!");
            }
            if(result <= 17)
            {
                Console.WriteLine("Ваш ИМТ: " + "{0:0.00}",result);
                Console.WriteLine("Вам следует набрать вес!");
            }
            
        }
    }
}
