using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class StaticVoid
    {
        //Функция ввода числа типа double
        public static double InputDouble()
        {
            string input; //строка ввода
            double output; //вывод числа
            input = Console.ReadLine();
            if (double.TryParse(input, out output) == true) //проверка на возможность преобразования к типу double
            {
                return output; //возврат числа
            }
            else //попытка повторного ввода
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Внимание! Вы ввели не число. Повторите ввод.");
                Console.ResetColor();
                return InputDouble();
            }
        }

        //Функция ввода числа типа int
        public static int InputInt()
        {
            string input;//Строка ввода
            int output;//Число вывода
            input = Console.ReadLine();
            if (int.TryParse(input, out output) == true)//Прочерка на возможность преобразования к типу
            {
                return output;//Возврат числа
            }
            else//Попытка повторного ввода
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Внимание! Вы ввели не число. Повторите ввод.");
                Console.ResetColor();
                return InputInt();
            }
        }
    }
}
