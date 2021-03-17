using System;

namespace HomeworkMishinN
{
    class Program
    {
        static void Main(string[] args)
        {
            //ф
            string name;
            string surname;
            int age;
            int height;
            double weight;

            Console.WriteLine("Введите имя: ");
            name = Console.ReadLine();
            Console.WriteLine("Введите фамилию: ");
            surname = Console.ReadLine();
            Console.WriteLine("Введите возраст: ");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите рост: ");
            height = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите вес: ");
            weight = double.Parse(Console.ReadLine());

            Console.WriteLine(name + " " + surname + " " + age + " " + height + " " + weight);
            Console.WriteLine(String.Format("{0} {1} {2} {3} {4}", name, surname, age, height, weight));
            Console.WriteLine($"{name} {surname} {age} {height} {weight}");
            Console.ReadKey();
        }
    }
}
