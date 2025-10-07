using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лр6
{
    internal class Fraction
    {
        int numenator;
        int denumenator;
        public Fraction(int numenator, int denumenator)
        {
            Numenator = numenator;
            Denumenator = denumenator;
        }
        public Fraction()
        {
            Numenator = 1;
            Denumenator = 1;
        }
        public int Numenator
        {
            get { return numenator; }
            set { numenator = value; }
        }
        public int Denumenator
        {
            get
            { return denumenator; }
            set
            {
                if (value == 0)
                {
                    denumenator = 1;
                    Console.WriteLine("В знаменателе не может быть нуля. Программа заменила ноль на единицу.");
                }
                else denumenator = value;
            }
        }
 
        public Fraction Summ(Fraction f1,Fraction f2)
        {
            Fraction fs = new Fraction();
            if (f2.Denumenator == f1.Denumenator)
            {
                fs.Numenator = f1.Numenator + f2.Numenator;
            }
            else
            {
                fs.Numenator = f1.Numenator * f2.Denumenator + f2.Numenator * f1.Denumenator;
                fs.Denumenator = f1.Denumenator * f2.Denumenator;
            }
            return fs;
        }
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
        public Fraction Diff(Fraction f1, Fraction f)
        {
            Fraction fd = new Fraction();
            if (f1.Denumenator == f.Denumenator)
            {
                fd.Numenator = f1.Numenator - f.Numenator;
                fd.Denumenator = f1.Denumenator;
            }
            else
            {
                fd.Numenator = f1.Numenator * f.Denumenator - f.Numenator * f1.Denumenator;
                fd.Denumenator = f1.Denumenator * f.Denumenator;
            }
            return fd;
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
        public Fraction Mult(Fraction f1, Fraction f)
        {
            Fraction fm = new Fraction();
            fm.Numenator = f1.Numenator * f.Numenator;
            fm.Denumenator = f1.Denumenator * f.Denumenator;
            return fm;
        }
        static public Fraction MultS(Fraction f1, Fraction f2)
        {
            return new Fraction(f1.Numenator * f2.Numenator, f1.Denumenator * f2.Denumenator);
        }
        public Fraction Div(Fraction f1, Fraction f)
        {
            Fraction fdiv = new Fraction();
            fdiv.Numenator = f1.Numenator * f.Denumenator;
            fdiv.Denumenator = f1.Denumenator * f.Numenator;
            return fdiv;
        }
        static public Fraction DivS(Fraction f1, Fraction f2)
        {
            return new Fraction(f1.Numenator * f2.Denumenator, f1.Denumenator * f2.Numenator);
        }
        static public Fraction operator +(Fraction f1, Fraction f2)
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

        static public Fraction operator -(Fraction f1, Fraction f2)
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

        static public Fraction operator *(Fraction f1, Fraction f2)
        {
            return new Fraction(f1.Numenator * f2.Numenator, f1.Denumenator * f2.Denumenator);
        }

        static public Fraction operator /(Fraction f1, Fraction f2)
        {
            return new Fraction(f1.Numenator * f2.Denumenator, f1.Denumenator * f2.Numenator);
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
        public void Info()
        {
            Console.WriteLine(numenator);
            Console.WriteLine("-");
            Console.WriteLine(denumenator);
        }
        public void Task1(Fraction f1, Fraction f2)
        {
            Fraction f3 = new Fraction();
            while (true)
            {
                Console.WriteLine("");
                Console.WriteLine("Операции над дробями\nГлавное меню");
                Console.WriteLine("Выберите пункт: ");
                Console.WriteLine("0. Выход\n" + "+. Сложение дробей;\n" +
                        "-. Вычитание дробей;\n" +
                        "*. Умножение дробей;\n" +
                        "/. Деление дробей;\n" +
                        "=. Информация о дробях;\n");
                Console.Write("Выберите пункт в меню: ");
                string menu = Console.ReadLine();
                Console.Clear();
                switch (menu)
                {
                    case "0":
                        return;
                    case "+":
                        f3 = Summ(f1, f2);
                        f3 = Fraction.Reduction(f3);
                        Console.WriteLine("Результат сложения дробей: ");
                        f3.Info();
                        break;
                    case "-":
                        f3 = Diff(f1, f2);
                        f3 = Fraction.Reduction(f3);
                        Console.WriteLine("Результат вычитания дробей: ");
                        f3.Info();
                        break;
                    case "*":
                        f3 = Mult(f1, f2);
                        f3 = Fraction.Reduction(f3);
                        Console.WriteLine("Результат умножения дробей: ");
                        f3.Info();
                        break;
                    case "/":
                        f3 = Div(f1, f2);
                        f3 = Fraction.Reduction(f3);
                        Console.WriteLine("Результат деления дробей: ");
                        f3.Info();
                        break;
                    case "=":
                        Console.WriteLine("Первая дробь");
                        Info();
                        Console.WriteLine("Вторая дробь");
                        f2.Info();
                        break;
                    default:
                        Console.WriteLine("Такого пункта нет в меню. Выберете другой пункт.");
                        break;
                }
            }
        }
        public void Task3(Fraction f1, Fraction f2)
        {
            Fraction f3 = new Fraction();
            while (true)
            {
                Console.WriteLine("");
                Console.WriteLine("Проверка работоспособности переопределенных операций\nМеню");
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
                        f3 = f1 + f2;
                        f3 = Fraction.Reduction(f3);
                        Console.WriteLine("Результат сложения дробей: ");
                        f3.Info();
                        break;
                    case "-":
                        f3 = f1 - f2;
                        f3 = Fraction.Reduction(f3);
                        Console.WriteLine("Результат вычитания дробей: ");
                        f3.Info();
                        break;
                    case "*":
                        f3 = f1 * f2;
                        f3 = Fraction.Reduction(f3);
                        Console.WriteLine("Результат умножения дробей: ");
                        f3.Info();
                        break;
                    case "/":
                        f3 = f1 / f2;
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
