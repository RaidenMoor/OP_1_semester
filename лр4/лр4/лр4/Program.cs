using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №4\nВыполнена студенкой группы 6101-020302 Гусевой Марией");
            while (true)
            {
                Console.WriteLine("Выберете пункт меню:\n0. Выход\n1. Десятичный счетчик\n2. Многочлен");
                int menu = int.Parse(Console.ReadLine());
                switch (menu)
                {
                    case 0:
                        return;
                    case 1:
                        Task1();
                        break;
                    case 2:
                        Task2();
                        break;
                    default:
                        Console.WriteLine("Введен несуществующий пункт. Повторите ввод.");
                        break;
                }
            }
        }
        static void Task1()
        {

            int max, min, tek;
            Console.WriteLine("Введите диапазон счетчика. Введите любое число, чтобы задать свой диапазон. Введите 0, чтобы задать здачения по умолчанию.");
            Console.Write("Максимальное значение: ");
            max = int.Parse(Console.ReadLine());
            Console.Write("\nМинимальное значение: ");
            min = int.Parse(Console.ReadLine());
            Console.Write("Текущее значение: ");
            tek = int.Parse(Console.ReadLine());
            Schetchik sch = new Schetchik(max, min, tek);
            while (true)
            {
                Console.WriteLine("\nВыберете действие: 0. Выход\n1.Увеличение числа на единицу\n2.Уменьшение числа на единицу\n3. Текущее состояние");
                int menu = int.Parse(Console.ReadLine());
                switch (menu)
                {
                    case 0:
                        return;
                    case 1:
                        sch.Plus();
                        break;
                    case 2:
                        sch.Low();
                        break;
                    case 3:
                        Console.WriteLine("Текущее состояние счетчика: " + sch.Current());
                        break;
                    default:
                        Console.WriteLine("Введен несуществующий пункт. Повторите ввод.");
                        break;
                }
            }
        }
        class Schetchik
        {
            public int max;
            public int min;
            public int tek;
            public Schetchik()
            {
                this.max = 10;
                this.min = 0;
                this.tek = 0;
            }
            public Schetchik(int max, int min, int tek)
            {
                this.max = max;
                this.min = min;
                this.tek = tek;
            }
            public void Plus()
            {
                if (tek == max)
                {
                    tek = min;
                    Console.WriteLine("Текущее значение достигло максимума. Присвоено минимальное значение");
                }
                tek++;
            }
            public void Low()
            {
                if (tek == min)
                {
                    tek = max;
                    Console.WriteLine("Текущее значение достигло минимума. Присвоено максимальное значение");
                }
                tek--;
            }
            public int Current()
            {
                return tek;
            }
        }
        static void Task2()
        {
            double a, b, c;
            Console.WriteLine("Введите коэффициенты a, b, c: ");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            Equation eq = new Equation(a, b, c);
            Console.WriteLine("Дискриминант равен: " + eq.Discriminant());
            if (eq.Discriminant() > 0)
            {
                Console.WriteLine("Корни уравнения равны: {0} и {1}", eq.Two_rootsx1(), eq.Two_rootsx2());
            }
            else if (eq.Discriminant() == 0)
            {
                Console.WriteLine("Корень уравнения равен: " + eq.One_root());
            }
            else
            {
                Console.WriteLine("Дискриминант меньше нуля. Корней нет.");
            }
        }
    }
    class Equation
    {
        public double a;
        public double b;
        public double c;
        public Equation(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public double Discriminant()
        {
            return 4 * b - 4 * a * c;
        }
        public double Two_rootsx1()
        {
            return -b + Math.Sqrt(4 * b - 4 * a * c) / 2 * a;
        }
        public double Two_rootsx2()
        {
            return -b - Math.Sqrt(4 * b - 4 * a * c) / 2 * a;
        }
        public double One_root()
        {
            return -b / 2 * a;
        }
    }
}