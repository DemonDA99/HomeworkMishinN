using System;

namespace WorkFourL2
{
    class Program
    {
        static void Main(string[] args)
        {
            string login;
            string password;
            int count = 0;

            do
            {
                Console.WriteLine("Введите логин: ");
                login = Console.ReadLine();

                Console.WriteLine("Введите пароль");
                password = Console.ReadLine();

                if (login == "root" && password == "GeekBrains")
                {
                    Console.WriteLine("Вход выполнен!");
                    break;
                }
                else
                {
                    Console.WriteLine("Неверный логин или пароль");
                    count++;
                }

            }
            while (count < 3);
        }
    }
}
