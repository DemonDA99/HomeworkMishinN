using System;

namespace WorkThreeL3
{
    class Fraction
    {
        public int numberOne;
        public int numberTwo;
 
        public Fraction(int numberOne, int numberTwo)
        {
            this.numberOne = numberOne;
            this.numberTwo = numberTwo;
        }
        public override string ToString()
        {
            return $"{numberOne}/{numberTwo}";
        }
 
        public static Fraction Sum(Fraction f1, Fraction f2)
        {
            return new Fraction(numberOne: (f1.numberOne * f2.numberTwo) + (f2.numberOne * f1.numberTwo), numberTwo: f1.numberTwo * f2.numberTwo);
        }
        public static Fraction Minus(Fraction f1, Fraction f2)
        {
            return new Fraction(numberOne: f1.numberOne - f2.numberOne, numberTwo: f1.numberTwo * f2.numberTwo);
        }
        public static Fraction Multiplication(Fraction f1, Fraction f2)
        {
            return new Fraction(numberOne: f1.numberOne * f2.numberOne, numberTwo: f1.numberTwo * f2.numberTwo);
        }
        public static Fraction Division(Fraction f1, Fraction f2)
        {
            return new Fraction(numberOne: f1.numberOne * f2.numberTwo, numberTwo: f1.numberTwo * f2.numberOne);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Fraction f1 = new Fraction(numberOne: 2, numberTwo: 3);
            Console.WriteLine("Дробь №1 " + f1);
            Fraction f2 = new Fraction(numberOne: 4, numberTwo: 5);
            Console.WriteLine("Дробь №2 " + f2);

            Console.Write("Введите символ(+,-,*,/) ");
            string str = Console.ReadLine();

            Fraction s = Fraction.Sum(f1, f2);
            Fraction m = Fraction.Minus(f1, f2);
            Fraction mu = Fraction.Multiplication(f1, f2);
            Fraction d = Fraction.Division(f1, f2);

            switch (str)
            {
                case "+":
                    Console.WriteLine("Сумма дробей равна: " + s);
                    break;
                case "-":
                    Console.WriteLine("Вычитание дробей равно: " + m);
                    break;
                case "*":
                    Console.WriteLine("Произведение дробей равно:" + mu);
                    break;
                case "/":
                    Console.WriteLine("Деление дробей равно: " + d);
                    break;
            }
            Console.ReadLine();

        }
    }
}
