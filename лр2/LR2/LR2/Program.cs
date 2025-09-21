using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Task1()
        {
            double xmax, xmin, dx, y;
            Console.WriteLine("Таблица значений функции");
            Console.Write("Введите x max: ");
            xmax = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите x min: ");
            xmin = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите шаг: ");
            dx = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\n\tx\t\ty\n");
            for (double x = xmin; x <= xmax; x += dx)
            {

                if ((x >= -7) && (x <= 3))
                {
                    if (x <= -6)
                        y = 2;
                    else
                    {
                        if (x <= -2)
                            y = 0.25 * x + 0.5;
                        else
                        {
                            if (x < 0)
                                y =  2 - Math.Sqrt(-(x*x) - 4 * x);
                            else
                            {
                                if (x <= 2)
                                {
                                    y = Math.Sqrt(4 - Math.Pow(x, 2));
                                }
                                else
                                {
                                    y = -x + 2;
                                }
                            }
                        }
                    }
                    Console.WriteLine("{0,10:0.00}{1,16:0.00}", x, y);

                }
                else
                {
                    string y0 = "Функция не определена";
                    Console.WriteLine("{0,10:0.00} {1,16:0.00}", x, y0);
                }

            }
        }
        static void Task2()
        {
                double x, y;
            Console.WriteLine("Серия выстрелов по мишени");
            for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine("Выстрел номер " + i);
                    Console.Write("Введите x:");
                    x = Convert.ToDouble(Console.ReadLine());
                    Console.Write("\nВведите y:");
                    y = Convert.ToDouble(Console.ReadLine());
                    if (y >= (Math.Pow((x - 2), 2) - 3))
                    {
                        if (y >= 0)
                        {
                            if (x >= Math.Abs(y))
                            {
                                Console.WriteLine("\nВы попали в мишень!\n");
                            }
                            else
                            {
                                Console.WriteLine("\nВы не попали в мишень.\n");
                            }
                        }
                        else
                        {
                            if (x <= Math.Abs(y))
                            {
                                Console.WriteLine("\nВы попали в мишень!\n");
                            }
                            else
                            {
                                Console.WriteLine("\nВы не попали в мишень.\n");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nВы не попали в мишень.\n");
                    }

                }
        }
        static void Task3()
        {
                {
                    double e, n, x, arctg, a;
                    Console.WriteLine("Сумма ряда");
                    Console.Write("Введите точность ");
                    e = Convert.ToDouble(Console.ReadLine());
                    Console.Write("\nВведите x ");
                    x = Convert.ToDouble(Console.ReadLine());
                    n = 0;
                    arctg = Math.PI / 2;
                    if (x > 1)
                    {
                        do
                        {
                            a = Math.Pow(-1, n + 1) / ((2 * n + 1) * Math.Pow(x, 2 * n + 1));
                            n++;
                            arctg += a;
                        } while (Math.Abs(e) < Math.Abs(a));
                        Console.WriteLine("Сумма ряда arctg(x) = " + arctg);
                        Console.WriteLine("Количество членов в ряду = " + n);
                    }
                    else
                    {
                        Console.WriteLine("Неверное значение x");
                    }
                    Console.ReadLine();
                }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №2\nВыполнена студенткой группы 6101-020302D Гусевой Марией");
            while (true)
            {
                Console.WriteLine("\nВыберите пункт: ");
                Console.WriteLine("0 - выход из программы\n1 - Таблица значений функции\n2 - Серия выстрелов по мишени\n3 - Сумма ряда");
                int menu = Convert.ToInt32(Console.ReadLine());

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
                    case 3:
                        Task3();
                        break;
                    default:
                        Console.WriteLine("Повторите ввод. Такого пункта нет в меню.");
                        break;
                }
            }
        }
    }
}

