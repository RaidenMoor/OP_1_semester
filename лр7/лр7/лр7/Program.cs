using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace лр7
{
    class Program
    {
        static void Main(string []args)
        {
            Console.WriteLine("Лабораторная работа №7 выполнила студентка группы 6101-020302D Гусева Мария");
            Console.WriteLine("Введите строку:");
            string s = Console.ReadLine();
            while (true)
            {
                Console.WriteLine("\nВыберете пункт:\n0.Выход\n1.подсчитать в строке число букв" +
                    "\n2.Подсчитать в строке среднюю длину слова" +
                    "\n3.Заменить в строке все вхождения заданного пользователем слова новым заданным пользователем словом" +
                    "\n4.Подсчитать в строке количество вхождений заданной подстроки" +
                    "\n5.Проверить, является ли строка палиндромом" +
                    "\n6.Проверить, является ли строка датой");
                int menu = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                switch(menu)
                {
                    case 0:
                        return;
                    case 1:
                        Console.WriteLine ("Количество букв в строке: " + Lines.CountLetters(s));

                        Console.WriteLine("Для возвращения в главное меню нажмите Enter");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine("Средняя длина слова: " + Lines.AverageLenght(s));
                        Console.WriteLine("Для возвращения в главное меню нажмите Enter");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3:
                        Console.WriteLine("Введите слово, которое хотите заменить: ");
                        string word = Console.ReadLine();
                        Console.WriteLine("Введите слово, на которое хотите заменить слово, написанное выше: ");
                        string change = Console.ReadLine();
                        Console.WriteLine("Результирующая строка после замены: " + Lines.WordsReplacement(s,word,change));
                        Console.WriteLine("Для возвращения в главное меню нажмите Enter");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 4:
                        Console.WriteLine("Введите часть строки: ");
                        string part = Console.ReadLine();
                        Console.WriteLine("Количество повторений части введённой строки: " + Lines.SubStrCounter(s, part));
                        Console.WriteLine("Для возвращения в главное меню нажмите Enter");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 5:
                        Lines.Palyndrom(s);
                        Console.WriteLine("Для возвращения в главное меню нажмите Enter");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 6:
                        Lines.Date(s);
                        Console.WriteLine("Для возвращения в главное меню нажмите Enter");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Такого пункта нет в меню. Введите другой пункт.");
                        break;
                }
            }
        }
    }
}
