using System;
using System.IO;
using System.Text.RegularExpressions;

namespace WorkOneL5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите логин: ");
            string login = Console.ReadLine() ;
            {
                if (login.Length < 2 || login.Length > 10)
                {
                    Console.WriteLine("Не коректная длина! ");
                }
                else
                {
                    if (char.IsDigit(login[0]))
                    {
                        Console.Write("Логин не может начинаться с цифры!");
                    }
                    else
                    {
                        for (int i = 0; i < login.Length; i++)
                        {
                            if (!(Char.IsDigit(login[i]) || login[i] >= 'a' && login[i] <= 'z' || login[i] >= 'A' && login[i] <= 'Z'))
                            {
                                Console.WriteLine("Недопустимые символы! ");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Коректный логин!");
                            }
                        }
                    }
                }
            }
            Regex regex = new Regex("[a-z]{1}[a-z0-9]{1,8}");
            Console.WriteLine(regex.IsMatch(login));
        }
    }
}
