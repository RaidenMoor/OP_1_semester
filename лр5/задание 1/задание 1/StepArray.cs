using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_1
{
    internal class StepArray
    {
        int[][] step_arr;
        int count_elements;
        public StepArray()
        {
            Console.WriteLine("Введите количество строк:");
            int n = int.Parse(Console.ReadLine());
            step_arr = new int[n][];
            for (int i = 0; i < step_arr.Length; i++)
            {
                Console.WriteLine("Введите элементы строки №{0} через пробел", i+1);
                string new_string = Console.ReadLine();
                step_arr[i] = new_string.Split(' ').Select(int.Parse).ToArray();
                count_elements += step_arr[i].Length;
                
            }
            Console.WriteLine("Ваш массив: ");
            for (int i = 0; i < step_arr.Length; i++)
            {
                for (int j = 0; j < step_arr[i].Length; j++)
                {
                    Console.Write(step_arr[i][j] + "\t");
                }
                Console.Write("\n");
            }
            
        }
        public void To_Simple_Array_And_Sort()
        {
            int[] simple_arr = new int[count_elements];
            int g = 0;
            for (int i = 0; i < step_arr.Length; i++)
            {
                for (int j = 0; j < step_arr[i].Length; j++)
                {
                    simple_arr[g] = step_arr[i][j];
                    g++;
                }
            }
            int v;
            for (int i = 0; i < simple_arr.Length; i++)
            {
                for (int j = i + 1; j < simple_arr.Length; j++)
                {
                    if (simple_arr[i] > simple_arr[j])
                    {
                        v = simple_arr[i];
                        simple_arr[i] = simple_arr[j];
                        simple_arr[j] = v;
                    }
                }
            }
            g = 0;
            for (int i = 0; i < step_arr.Length; i++)
                {
                    for (int j = 0; j < step_arr[i].Length; j++)
                    {
                        step_arr[i][j]= simple_arr[g];
                        g++;
                    }
                }
            Console.WriteLine("\nОтсортированный массив:");
            for (int i = 0; i < step_arr.Length; i++)
            {
                for (int j = 0; j < step_arr[i].Length; j++)
                {
                    Console.Write(step_arr[i][j] + "\t");
                }
                Console.Write("\n");
            }
        }
        public void Step_Array_Info()
        {
            Console.WriteLine("\nОбщая размерность массива: " + step_arr.Length + "\n");
            for (int i = 0; i < step_arr.Length; i++)
            {
                Console.WriteLine("Количество элементов в строке №{0}: {1}", i+1,step_arr[i].Length);
            }
            Console.Write("\n");
        }
    }
}
