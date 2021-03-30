using System;
using System.IO;
using System.Text.RegularExpressions;

namespace WorkTwoL5
{
    static class Message
    {
        public static string StringEnd()
        {
            Console.Write("Введите сообщение: ");
            string str = Console.ReadLine();
            

            string regex = (@"\b\w{1,5}(?=\b)");

            foreach (Match m in Regex.Matches(str, regex))
            {
                Console.WriteLine(m.Value);
            }
            return str;
        }
        public static string Delite()
        {
            const string Char = "f";
            Console.Write("Введите сообщение: ");
            string str = Console.ReadLine();

            str = (new Regex("[a-z]+" + Char)).Replace(str, "").Trim();
            Console.WriteLine(str);
            return str;
        }

        static void Main(string[] args)
        {
            StringEnd();
            Delite();
            Console.WriteLine();
        }
    }
}
