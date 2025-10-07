using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using задание_1;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string []args)
        {
            Console.WriteLine("Лабораторная работа №5\nВыполнила студентка группы 6101-020302D Гусева Мария");
            while (true)
            {
                
                Console.WriteLine("\nВведите пункт меню:");
                Console.WriteLine("0 - Выход\n1 - Сортировка одномерного массива\n2 - Двумерные массивы\n3 - Ступенчатые массивы");
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
                    case 3:
                        Task3();
                        break;
                    default:
                        Console.WriteLine("Такого пункта не существует. Введите другой пункт.");
                        break;
                }
            }
        }
        static void Task1()
        {
            Console.WriteLine("Введите массив:");
            SortArray a = new SortArray();
            Console.WriteLine("Выберете способ сортировки:\n1 - Сортировка пузырьком\n2 - Сортировка Шелла\n3 - Сортировка вставкой");
            int menu = int.Parse(Console.ReadLine());
            switch (menu)
            {
                case 0:
                    break;
                case 1:
                    Console.WriteLine("Сортировка пузырьком: ");
                    a.BubbleSort();
                    break;
                case 2:
                    Console.WriteLine("Сортировка Шелла");
                    a.SortShell();
                    break;
                case 3:
                    Console.WriteLine("Сортировка вставками");
                    a.SortByInserts();
                    break;
                default:
                    Console.WriteLine("Такого пункта не существует!");
                    break;
            }            
           
        }
        static void Task2()
        {
            MyMas mas = new MyMas();
            mas.Vivod();
            mas.SortInDescending();
            mas.SortInAscending();
        }
        static void Task3()
        {
            
            StepArray arr = new StepArray();         
            arr.Step_Array_Info();
            arr.To_Simple_Array_And_Sort();
        }
    }     
}


