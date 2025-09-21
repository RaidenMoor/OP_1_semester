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
            double x, y;
            Console.WriteLine("Введите x:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y:");
            y = Convert.ToDouble(Console.ReadLine());

            if (y >= (Math.Pow((x - 2), 2) - 3)) 
            {
                if (y >= 0)
                {
                    if (x >= Math.Abs(y))
                    {
                        Console.WriteLine("Точка принадлежит выделенной области");
                    }
                    else
                    {
                        Console.WriteLine("Точка не принадлежит выделенной области");
                    }
                }
                else 
                {
                    if (x <= Math.Abs(y)) 
                    {
                        Console.WriteLine("Точка принадлежит выделенной области");
                    }
                    else
                    {
                        Console.WriteLine("Точка не принадлежит выделенной области");
                    }
                }
            }
            else
            {
                Console.WriteLine("Точка не принадлежит выделенной области");
            }
            Console.ReadLine();
        }
    }
}
