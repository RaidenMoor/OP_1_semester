using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лр7
{
    internal class Lines
    {
        public string s;
        public Lines(string s)
        {
            this.s = s;
        }
        static void GetWord(string s)
        {
            String[] words = s.Split(new char[] { ' ', ',', '-', ';', ':', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        }
        static public int CountLetters(string s)
        {
            int k = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if ((s[i] >= 'a' && s[i] <= 'z') || (s[i] >= 'A' || s[i] <= 'Z'))
                    k++;

            }
            return k;
        }
        static public double AverageLenght(string s)
        {
            s.ToLower();
            String[] words = s.Split(new char[] { ' ', ',', '-', ';', ':', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            double sum = 0;
            for (int i = 0; i < words.Length; i++)
            {
                sum += words[i].Length;
            }
            return  (sum / words.Length);
        }
        static public string WordsReplacement(string s, string word, string change)
        {
            string s1 = s.ToLower(), wrd;
            change = change.ToLower();
            int fp = 0;
            String[] words = s1.Split(new char[] { ' ', ',', '-', ';', ':', '.', '!', '?' });
            for (int i = 0; i < words.Length; i++)
            {
                wrd = words[i];
                if (words[i] == word)
                {
                    s1 = s1.Remove(fp, words[i].Length);
                    wrd = wrd.Replace(words[i], change);
                    s1 = s1.Insert(fp, wrd);
                }
                if (char.IsLetter(s1[words[i].Length + 2]))
                {
                    fp += words[i].Length + 1;
                }
                else
                {
                    int j = 1;
                    while (!char.IsLetter(s1[words[i].Length + j]))
                    {
                        j++;
                    }
                    fp += words[i].Length + j - 1;
                }
            }
            return s1;

        }
        static public int SubStrCounter(string s, string part)
        {
            string s1 = s.ToLower();
            int i = 0;
            while (s1.Contains(part))
            {
                i++;
                s1 = s1.Substring(s1.IndexOf(part) + part.Length);
            }
            return i;
        }
        static public void Palyndrom(string s)
        {
            
            string s1 = s.ToLower();
            String[] letter = s1.Split(new char[] { ' ', ',', '-', ';', ':', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            s1 = string.Join("", letter);
            bool key = true;
            for (int i = 0; i < (s1.Length / 2); i++)
            {
                if (s1[i] != s1[s1.Length - i - 1])
                {
                    key = false;
                    break;
                }
            }
            if (key == true)
            {
                Console.WriteLine("Строка является палиндромом");
            }
            else
            {
                Console.WriteLine("Строка не является палиндромом");
            }
        }
        static public void Date(string s)
        {
            string date = s.ToLower();
            if ((date.Length == 8) || (date.Length == 10))
            {
                int[] _date = date.Split('.').Select(int.Parse).ToArray();
                int day = _date[0];
                int months = _date[1];
                int year = _date[2];
                if ((day < 32) && (months > 0) && (months < 12))
                {
                    if (((months == 1) || (months == 3) || (months ==5) || (months == 7) || (months == 8) || (months == 10) || (months == 12)) && (day < 32))
                    {
                        Console.WriteLine("Дата корректна");
                    }
                    else if(((months == 2) || (months == 4) || (months == 6) || (months == 8) || (months == 9) || (months == 11)) && (day < 31))
                    {
                        Console.WriteLine("Дата корректна");
                    }
                    else if (months == 2 && ((year % 4 == 0 && day < 30) || (year % 4 != 0 && day < 29)))
                    {
                        Console.WriteLine("Дата корректна");
                    }
                    else
                    {
                        Console.WriteLine("Дата некорректна");
                    }
                }
            }
            else Console.WriteLine("Введённое значение не является датой");
        }

    }
}
