using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using лр6;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string []args)
        {
            Fraction f1 = new Fraction();
            Fraction f2 = new Fraction();
            bool key = false;
            Console.WriteLine("Лабораторная работа №6\nВыполнила студентка группы 6101-020302D Гусева Мария");
            while(true)
            {
                Console.WriteLine("Выберете пункт меню:0.Выход\n1.Введение новых дробей");
                string menu0 = Console.ReadLine();
                switch (menu0)
                {
                    case "0":
                        return;
                    case "1":
                        Console.WriteLine("Введите числитель первой дроби: ");
                        f1.Numenator = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите знаменатель первой дроби: ");
                        f1.Denumenator = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите числитель второй дроби: ");
                        f2.Numenator = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите знаменатель второй дроби: ");
                        f2.Denumenator = int.Parse(Console.ReadLine());
                        Fraction f3 = new Fraction();
                        StaticFraction stat = new StaticFraction();
                        while (key == false)
                        {
                            Console.WriteLine("Выберете пункт:\n0.Выход\n1.Операции над дробями"+
                                "\n2.Проверка работоспособности статических методов" +
                                "\n3.Проверка работоспособности переопределенных операций");
                            string menu1 = Console.ReadLine();
                            switch (menu1)
                            {
                                case "0":
                                    key = true;
                                    break;
                                case "1":
                                    f1.Task1(f1,f2);
                                    Console.WriteLine("Для возвращения в главное меню нажмите 'Enter'");
                                    break;
                                case "2":
                                    stat.Task2(f1,f2);
                                    Console.WriteLine("Для возвращения в главное меню нажмите 'Enter'");
                                    break;
                                case "3":
                                    f1.Task3(f1, f2);
                                    Console.WriteLine("Для возвращения в главное меню нажмите 'Enter'");
                                    break;
                                default:
                                    Console.WriteLine("Такого пункта меню не существует.Введите другой пункт.");
                                    break;
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("Такого пункта не существует. Введите другой пункт");
                        break;

                }
            }

        }
    }
}

