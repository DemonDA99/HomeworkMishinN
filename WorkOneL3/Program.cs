using System;

namespace WorkOneL3
{
    struct Complex
    {
        double a;
        double b;

        public Complex(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public override string ToString()
        {
            if(b < 0)
            {
                return $"{a} - {b}i";
            }
            return $"{a} + {b}i";
        }
        public static Complex Sum(Complex z1, Complex z2)
        {
            return new Complex(a: z1.a + z2.a, b: z1.b + z2.b);
        }
        public static Complex Minus(Complex z1, Complex z2)
        {
            return new Complex(a: z1.a - z2.a, b: z1.b - z2.b);
        }
        public static Complex Multiplication(Complex z1, Complex z2)
        {
            return new Complex(a: (z1.a * z2.a) - (z1.b * z2.b), b: (z1.b * z2.a) + (z1.a * z2.b));
        }
        public static Complex Division(Complex z1, Complex z2)
        {
            return new Complex(a: (z1.a * z2.a + z1.b * z2.b) / ((z2.a * z2.a) + (z2.b * z2.b)), b: ((z2.a * z1.b) - (z1.a * z2.b)) / ((z2.a * z2.a) + (z2.b * z2.b)));
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Complex z1 = new Complex(a: 12, b: 23);
            Console.WriteLine("Комплексное число №1 " + z1);

            Complex z2 = new Complex(a: 9, b: 39);
            Console.WriteLine("Комплексное число №2 " + z2);

            Console.Write("Введите символ(+,-,*,/) ");
            string str = Console.ReadLine();

            Complex s = Complex.Sum(z1, z2);
            Complex m = Complex.Minus(z1, z2);
            Complex mu = Complex.Multiplication(z1, z2);
            Complex d = Complex.Division(z1, z2);
           
            switch (str)
            {
                case "+":
                    Console.WriteLine("Сумма комплексных чисел равна: " + s);
                    break;
                case "-":
                    Console.WriteLine("Вычитание комплексных чисел равно: " + m);
                    break;
                case "*":
                    Console.WriteLine("Произведение комплексных чисел равно:" + mu);
                    break;
                case "/":
                    Console.WriteLine("Деление комплексных чисел равно: " + d);
                    break;
            }
            Console.ReadLine();
        }
    }
}
