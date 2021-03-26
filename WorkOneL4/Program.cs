using System;

namespace WorkOneL4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArray a = new MyArray(20, -10000, 10000);
            Console.WriteLine(a.ToString());
            Console.WriteLine(a.pairsOfNumbers());
        }
    }
    class MyArray
    {
        int[] numbers;
        
        public MyArray(int n, int min, int max)
        {
            numbers = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                numbers[i] = rnd.Next(min, max);
        }
        public override string ToString()
        {
            string s = "";
            foreach (int v in numbers)
                s = s + v + " ";
            return s;
        }
        public int pairsOfNumbers()
        {
            int count = 0;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] % 3 == 0 | numbers[i + 1] % 3 == 0)
                    count++;
            }
            return count;
        }
    }

}
