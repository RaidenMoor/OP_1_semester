using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_1
{
    internal class MyMas
    {
        private int[,] mas;
        public MyMas()
        {
            Console.WriteLine("Введите количество строк: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов: ");
            int m = int.Parse(Console.ReadLine());
            mas = new int[n, m]; 
            Random rand = new Random();
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                {
                    mas[i, j] = rand.Next(-100, 100);
                }
        }

        public void Vivod() //Метод вывода матрицы
        {
            Console.WriteLine("Исходная матрица:");
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    Console.Write(mas[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }
        }
        public void SortInDescending()
        {
            int[] sum = new int[mas.GetLength(1)];
            for (int j = 0; j < mas.GetLength(1); j++)
            {
                for (int i = 0; i < mas.GetLength(0); i++)
                {
                    sum[j] += mas[i, j];
                }
            }

            int v;
            int[] index_sort = new int[mas.GetLength(1)];
            for (int j = 0; j < mas.GetLength(1); j++)
            {
                index_sort[j] = j + 1;
            }
            for (int i = 0; i < mas.GetLength(1); i++)
            {
                for (int j = i + 1; j < mas.GetLength(1); j++)
                {
                    if (sum[i] < sum[j])
                    {
                        v = sum[i];
                        sum[i] = sum[j];
                        sum[j] = v;
                        v = index_sort[i];
                        index_sort[i] = index_sort[j];
                        index_sort[j] = v;
                    }
                }
            }
            Console.WriteLine("Результат сортировки по сумме элементов столбцов по убыванию:");
            int[,] mas_sort = new int[mas.GetLength(0), mas.GetLength(1)];
            for (int k = 0; k < mas.GetLength(1); k++)
            {
                for (int i = 0; i < mas.GetLength(0); i++)
                {
                    mas_sort[i, k] = mas[i, index_sort[k] - 1];
                }
            }
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    Console.Write(mas_sort[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }
        }
        public void SortInAscending()
        {
            int[] sum = new int[mas.GetLength(1)];
            for (int j = 0; j < mas.GetLength(1); j++)
            {
                for (int i = 0; i < mas.GetLength(0); i++)
                {
                    sum[j] += mas[i, j];
                }
            }

            int v;
            int[] index_sort = new int[mas.GetLength(1)];
            for (int j = 0; j < mas.GetLength(1); j++)
            {
                index_sort[j] = j + 1;
            }
            for (int i = 0; i < mas.GetLength(1); i++)
            {
                for (int j = i + 1; j < mas.GetLength(1); j++)
                {
                    if (sum[i] > sum[j])
                    {
                        v = sum[i];
                        sum[i] = sum[j];
                        sum[j] = v;
                        v = index_sort[i];
                        index_sort[i] = index_sort[j];
                        index_sort[j] = v;
                    }
                }
            }
            Console.WriteLine("Результат сортировки по сумме элементов столбцов по возрастанию:");
            int[,] mas_sort = new int[mas.GetLength(0), mas.GetLength(1)];
            for (int k = 0; k < mas.GetLength(1); k++)
            {
                for (int i = 0; i < mas.GetLength(0); i++)
                {
                    mas_sort[i, k] = mas[i, index_sort[k]-1];                
                }
            }
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    Console.Write(mas_sort[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
