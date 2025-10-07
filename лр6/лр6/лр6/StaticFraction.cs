using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лр6
{
    internal class StaticFraction
    {
        static public Fraction SummaS(Fraction f1, Fraction f2)
        {
            if (f1.Denumenator == f2.Denumenator)
            {
                return new Fraction(f1.Numenator + f2.Numenator, f1.Denumenator);
            }
            else
            {
                return new Fraction(f1.Numenator * f2.Denumenator + f2.Numenator * f1.Denumenator, f1.Denumenator * f2.Denumenator);
            }
        }
        static public Fraction DiffS(Fraction f1, Fraction f2)
        {
            if (f1.Denumenator == f2.Denumenator)
            {
                return new Fraction(f1.Numenator - f2.Numenator, f1.Denumenator);
            }
            else
            {
                return new Fraction(f1.Numenator * f2.Denumenator - f2.Numenator * f1.Denumenator, f1.Denumenator * f2.Denumenator);
            }
        }
        static public Fraction MultS(Fraction f1, Fraction f2)
        {
            return new Fraction(f1.Numenator * f2.Numenator, f1.Denumenator * f2.Denumenator);
        }
        static public Fraction DivS(Fraction f1, Fraction f2)
        {
            return new Fraction(f1.Numenator * f2.Denumenator, f1.Denumenator * f2.Numenator);
        }
        static public Fraction Reduction(Fraction f)
        {
            int n = NOD(f.Numenator, f.Denumenator);
            if (n != 0)
            {
                Console.WriteLine("Результирующая дробь сокращена на число " + n);
                return new Fraction(f.Numenator / n, f.Denumenator / n);
            }
            else
            {
                return new Fraction(0, 0);
            }
        }
        static public int NOD(int numenator, int denumenator)
        {
            while ((numenator != 0) && (denumenator != 0))
            {
                if (numenator > denumenator)
                {
                    numenator %= denumenator;
                }
                else
                {
                    denumenator %= numenator;
                }
            }
            if (numenator + denumenator != 0)
            {
                return numenator + denumenator;
            }
            else
            {
                return 0;
            }
        }
        static public void Info(Fraction f)
        {
            Console.WriteLine(f.Numenator);
            Console.WriteLine("-");
            Console.WriteLine(f.Denumenator);
        }
        public void Task2(Fraction f1, Fraction f2)
        {
            Fraction f3 = new Fraction();
            while (true)
            {
                Console.WriteLine("");
                Console.WriteLine("Проверка работоспособности статических методов\nМеню");
                Console.WriteLine("Выберите пункт: ");
                Console.WriteLine("0. Выход\n" + "+. Сложение дробей;\n" +
                        "-. Вычитание дробей;\n" +
                        "*. Умножение дробей;\n" +
                        "/. Деление дробей;\n" +
                        "=. Информация о дробях;\n");
                string menu3 = Console.ReadLine();
                Console.Clear();
                switch (menu3)
                {
                    case "0":
                        return;
                    case "+":
                        f3 = StaticFraction.SummaS(f1, f2);
                        f3 = Fraction.Reduction(f3);
                        Console.WriteLine("Результат сложения дробей: ");
                        f3.Info();
                        break;
                    case "-":
                        f3 = StaticFraction.DiffS(f1, f2);
                        f3 = Fraction.Reduction(f3);
                        Console.WriteLine("Результат вычитания дробей: ");
                        f3.Info();
                        break;
                    case "*":
                        f3 = StaticFraction.MultS(f1, f2);
                        f3 = Fraction.Reduction(f3);
                        Console.WriteLine("Результат умножения дробей: ");
                        f3.Info();
                        break;
                    case "/":
                        f3 = StaticFraction.DivS(f1, f2);
                        f3 = Fraction.Reduction(f3);
                        Console.WriteLine("Результат деления дробей: ");
                        f3.Info();
                        break;
                    case "=":
                        Console.WriteLine("Первая дробь");
                        f1.Info();
                        Console.WriteLine("Вторая дробь");
                        f2.Info();
                        break;
                    default:
                        Console.WriteLine("Такого пункта нет в меню. Выберете другой пункт.");
                        break;
                }
            }

        }
    }
}
