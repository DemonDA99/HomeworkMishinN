using System;
using System.IO;

namespace WorkTwoL4
{
     public static class StaticClass
    {
        public static int[] Print(int n)
        {
            int[] numbers = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = rnd.Next(-10000, 10000);
            return numbers;
            
        }
        public static int[] MyArray()
        {
            StreamReader sr = new StreamReader("C:\\Users\\Owner\\Desktop\\C#\\Курсы\\HomeworkMishinN\\Data.txt");
            int N = int.Parse(sr.ReadLine());
            int[] masData = new int[N];
            try
            {
                for (int i = 0; i < N; i++)
                {
                    masData[i] = int.Parse(sr.ReadLine());
                    Console.WriteLine(masData);
                }
            }
            catch
            {
                Console.WriteLine("Файл отсутствует на диске!");
            }
            return masData;
        }
         public static void Main(string[] args)
        {
            int n = 20;
            int[] mas = StaticClass.Print(n);
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", mas[i]);
            }
        }
    }
}
   
