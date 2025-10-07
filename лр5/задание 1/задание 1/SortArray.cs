using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace задание_1
{
    internal class SortArray
    {
        private int[] a;
        public SortArray()
        {
            string c = Console.ReadLine();
            a = c.Split(' ').Select(int.Parse).ToArray();
        }
        public void BubbleSort()
        {
            int v;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] > a[j])
                    {
                        v = a[i];
                        a[i] = a[j];
                        a[j] = v;
                    }
                }
            }
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine("\n");
        }
        public void SortShell()
        {
            {
                int j;
                int step = a.Length / 2;
                while (step > 0)
                {
                    for (int i = 0; i < (a.Length - step); i++)
                    {
                        j = i;
                        while ((j >= 0) && (a[j] > a[j + step]))
                        {
                            int tmp = a[j];
                            a[j] = a[j + step];
                            a[j + step] = tmp;
                            j -= step;
                        }
                    }
                    step = step / 2;
                }
                for (int i = 0; i < a.Length; i++)
                {
                    Console.Write(a[i] + " ");
                }
                Console.Write("\n");
            }
        }
        public void SortByInserts()
        {
            for (int i = 1; i < a.Length; i++)
            {
                int k = a[i];
                int j = i - 1;

                while (j >= 0 && a[j] > k)
                {
                    a[j + 1] = a[j];
                    a[j] = k;
                    j--;
                }
            }
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.Write("\n");
        }

    }
}
