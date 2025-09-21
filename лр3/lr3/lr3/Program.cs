using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №3\nВыполнила студентка группы 6101-020302D Гусева Мария");
            while (true)
            {
                Console.WriteLine("\nВыберете пункт меню:\n0. Выход\n1. Ввод и обработка матриц\n2.Перевод из двоичной системы счисления в десятичную\n");
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
                        Console.WriteLine("Такого пункта нет в меню. Повторите ввод");
                        break;
                }
            }
        }
        static void Task1()
        {
            int n, m;


            Console.Write("Введите количество строк: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("\nВведите количество столбцов: ");
            m = int.Parse(Console.ReadLine());

            if ((n > 10) || (m > 10))
            {
                Console.WriteLine("\nКоличество строк и столбцов не должно превышать 10! Введите значения повторно.");
                Console.Write("Введите количество строк: ");
                n = int.Parse(Console.ReadLine());
                Console.Write("Введите количество столбцов: ");
                m = int.Parse(Console.ReadLine());
            }
            int[,] mas1 = new int[n, m];
            int[,] mas2 = new int[n, m];
            Console.WriteLine("Введение элементов первой матрицы: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mas1[i, j] = int.Parse(Console.ReadLine());

                }
                Console.Write("\n");
            }
            Console.WriteLine("Введение элементов второй матрицы: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mas2[i, j] = int.Parse(Console.ReadLine());
                }
                Console.Write("\n");
            }
            while (true)
            {
                Console.WriteLine("\nВыберете действие, которое хотите произвести с матрицами: ");
                Console.WriteLine("0.Выход\n1.Cложение\n2.Вычитание\n3.Умножение\n4.Умножение на число\n5.Сравнение на равенство");
                int menu = int.Parse(Console.ReadLine());
                switch (menu)
                {
                    case 0:
                        return;
                    case 1:
                        int[,] smas = new int[n, m];
                        Console.WriteLine("Результат сложения матриц: ");
                        for (int i = 0; i < n; i++)
                        {
                            for (int j = 0; j < m; j++)
                            {
                                smas[i, j] = mas1[i, j] + mas2[i, j];
                                Console.Write(smas[i, j] + "\t");
                            }
                            Console.Write("\n");
                        }
                        break;
                    case 2:
                        int[,] difmas = new int[n, m];
                        Console.WriteLine("Результат вычитания матриц: ");
                        for (int i = 0; i < n; i++)
                        {
                            for (int j = 0; j < m; j++)
                            {
                                difmas[i, j] = mas1[i, j] - mas2[i, j];
                                Console.Write(difmas[i, j] + "\t");
                            }
                            Console.Write("\n");
                        }
                        break;
                    case 3:
                        int[,] mas = new int[n, m];
                        Console.WriteLine("Результат перемножения матриц: ");
                        if (n == m)
                        {
                            for (int i = 0; i < n; i++)
                            {
                                for (int j = 0; j < m; j++)
                                {
                                    for (int k = 0; k < m; k++)
                                    {
                                        mas[i, j] += mas1[i, k] * mas2[k, j];
                                        
                                    }
                                    Console.Write(mas[i, j] + "\t");
                                }
                                Console.Write("\n");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Не выполняется условие для перемножения матриц.");
                        }
                        break;
                    case 4:
                        int s, g;
                        Console.Write("Выберете матрицу: ");
                        g = int.Parse(Console.ReadLine());
                        switch (g)
                        {
                            case 1:
                                Console.Write("Введите число, на которое хотите умножить матрицу: ");
                                s = int.Parse(Console.ReadLine());
                                int[,] mas1s = new int[n, m];
                                Console.WriteLine("Результат умножения первой матрицы на число: ");
                                for (int i = 0; i < n; i++)
                                {
                                    for (int j = 0; j < m; j++)
                                    {
                                        mas1s[i, j] = mas1[i, j] * s;
                                        Console.Write(mas1s[i, j] + "\t");
                                    }
                                    Console.Write("\n");
                                }
                                break;
                            case 2:
                                Console.Write("Введите число, на которое хотите умножить матрицу: ");
                                s = int.Parse(Console.ReadLine());
                                int[,] mas2s = new int[n, m];
                                Console.WriteLine("Результат умножения второй матрицы на число: ");
                                for (int i = 0; i < n; i++)
                                {
                                    for (int j = 0; j < m; j++)
                                    {
                                        mas2s[i, j] = mas1[i, j] * s;
                                        Console.Write(mas2s[i, j] + "\t");
                                    }
                                    Console.Write("\n");
                                }
                                break;
                            default:
                                Console.WriteLine("Нет такой матрицы.");
                                break;
                        }
                        break;
                    case 5:
                        bool p = true;
                        for (int i = 0; i < n; i++)
                        {
                            for (int j = 0; j < m; j++)
                            {
                                if (mas1[i, j] == mas2[i, j])
                                {
                                    continue;
                                }
                                else
                                {
                                    Console.WriteLine("Матрицы не равны. Не равные элементы находятся в {0} строке {1} столбце", i + 1, j + 1);
                                    p = false;
                                    break;
                                }
                            }
                            if (p == false)
                            {
                                break;
                            }
                        }
                        if (p == true)
                        {
                            Console.WriteLine("Матрицы равны.");
                        }
                        break;
                    default:
                        Console.WriteLine("В меню нет такого пункта. Введите другой номер пункта");
                        break;
                }
            }
        }
        static void Task2()
        {
            int num, a = 0, i = 0, v, j = 3, s1 = 0;
            int[] b = new int[9];
            int[] s = new int[9];
            Console.WriteLine("Введите число в десятичной системе");
            num = Convert.ToInt32(Console.ReadLine());

            while (num >= 1)
            {
                a = num % 2;
                b[i] = a;
                i++;
                num = num / 2;
   
            }
            Console.Write("\nЧисло в двоичной системе: ");
            for (i = (b.Length - 1); i >= 0; i--)
            {
                s[b.Length - 1 - i] = b[i];
                Console.Write(b[i]);
            }

            Console.WriteLine("\nСмена первой и третье триад: ");
            for (i = 0; i <= 2; i++)
            {
                v = s[i];
                s[i] = s[b.Length - j];
                s[b.Length - j] = v;
                j--;
            }
            for (i = 0; i < b.Length; i++)
            {
                Console.Write(s[i]);
            }
            for (i = 0; i < s.Length; i++)
            {
                s1 += s[i] * Convert.ToInt32(Math.Pow(2, i));
            }
            Console.WriteLine("\nНовое число в десятичной системе счисления: " + s1);
        }
    }
}