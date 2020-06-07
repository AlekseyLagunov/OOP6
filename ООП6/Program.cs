using System;

namespace ООП6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1:");
            Zadanie1 a1 = new Zadanie1();
            Zadanie1 a2 = new Zadanie1(1);
            Zadanie1 a3 = new Zadanie1(2,7);
            a1.Read();
            a2.Read();
            a3.Read();
            Console.WriteLine("---------------");

            Console.WriteLine("Задание 2:");
            Zadanie2 b1 = new Zadanie2();
            Zadanie2 b2 = new Zadanie2();
            Zadanie2 b3 = new Zadanie2();
            b1.Write();
            b2.Write("Привет!");
            b3.Write("Привет! Привет! Привет!");
            b1.Read();
            b2.Read();
            b3.Read();
            Console.WriteLine("---------------");

            Console.WriteLine("Задание 3:"); 
            Zadanie3 c1 = new Zadanie3(30, 4, 5);
            Console.WriteLine("");
            Zadanie3 c2 = new Zadanie3(3,4,5);
            Console.WriteLine("---------------");

            Console.ReadKey();
        }
    }
    class Zadanie3
    {
        public double a;
        public double b;
        public double c;
        public Zadanie3(int s1,int s2,int s3)
        {
            a = s1;b = s2;c = s3;
            if (  (a + b > c) && (b + c > a) && (c + a > b)  ) Console.WriteLine("Треугольник со сторонами "+a+" "+ b + " " + c + " возможен");
            else Console.WriteLine("Треугольник со сторонами " + a + " " + b + " " + c + " не возможен");
            double ug1 = Math.Acos(    (  Math.Pow(a, 2) + Math.Pow(c, 2) - Math.Pow(b, 2)  ) / (2*a*c)    );
            ug1 =  (ug1*180) / Math.PI;
            double ug2 = Math.Acos(    (  Math.Pow(b, 2) + Math.Pow(a, 2) - Math.Pow(c, 2)  ) / (2*b*a)    );
            ug2 = (ug2 * 180) /  Math.PI;
            double ug3 = Math.Acos(    (  Math.Pow(c, 2) + Math.Pow(b, 2) - Math.Pow(a, 2)  ) / (2*c*b)    );
            ug3 = (ug3 *180) / Math.PI;
            Console.WriteLine("Угол 1 = " + (ug1));
            Console.WriteLine("Угол 2 = " + (ug2));
            Console.WriteLine("Угол 3 = " + (ug3));
        }
    }
    class Zadanie2
    {
        private string st1="Пусто";
        public void Write()
        {
        }
        public void Write(string st)
        {
            if (st.Length > 10) st1 = "Слишком длинная строка";
            else st1 = st;
        }
        public void Read()
        {
            Console.WriteLine(st1);
        }
    }
    class Zadanie1
    {
        public int number1;
        public int number2;
        public Zadanie1()
        {
        }
        public Zadanie1(int n1)
        {
            number1 = n1;
        }
        public Zadanie1(int n1,int n2)
        {
            number1 = n1;
            number2 = n2;
        }
        public void Read()
        {
            Console.WriteLine(number1 + " " + number2);
        }
    }
}
