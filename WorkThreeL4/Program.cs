using System;

namespace WorkThreeL4
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }
    }
    public class Arrays
    {
        public int[] MainArray { get; set; }
        public int Maxcout { get; set; }

        public Arrays(int count, int start, int step)
        {
            for (int i = 0; i < count; i++)
            {
                MainArray[i] = start + (step * i);
            }
        }

        public int Sum(int[] arr)
        {
            int s = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                s += arr[i];
            }
            return s;
        }

        public int[] Inverse(int[] arr)
        {
            int[] newArr = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = -arr[i];
            }

            return newArr;
        }

        public int[] Multi(int[] arr, int mlt)
        {
            int[] newArr = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = mlt * arr[i];
            }

            return newArr;
        }

        public int MaxCounter(int[] arr)
        {
            int max = arr.Max();
            int s = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == max)
                    s += 1;
            }
            return s;
        }

    }
}
