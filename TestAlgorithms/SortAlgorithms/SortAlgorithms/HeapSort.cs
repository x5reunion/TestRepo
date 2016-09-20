using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortAlgorithms
{
    public class HeapSort
    {
        // Не реализован. Принцип работы неясен.
        // https://ru.wikipedia.org/wiki/Пирамидальная_сортировка

        public static void Sort(int[] data)
        {
            //for (int i = data.Length / 2 - 1; i >= 0; i--)
            //{
            //    ShiftDown(data, i, data.Length);
            //}

            //for (int i = data.Length - 1; i >= 1; i--)
            //{
            //    Swap(ref data[0], ref data[i]);
            //    ShiftDown(data, 0, i);

            //    foreach (var n in data)
            //    {
            //        Console.Write("{0} ", n);
            //    }

            //    Console.WriteLine();
            //}
        }

        private static void ShiftDown(int[] data, int i, int j)
        {
            bool done = false;
            int maxChild = 0;

            while ((i * 2 + 1 < j) && (!done))
            {
                if (i * 2 + 1 == j - 1)
                    maxChild = i * 2 + 1;
                else if (data[i * 2 + 1] > data[i * 2 + 2])
                    maxChild = i * 2 + 1;
                else
                    maxChild = i * 2 + 2;

                if (data[i] < data[maxChild])
                {
                    Swap(ref data[i], ref data[maxChild]);

                    i = maxChild;
                }
                else
                {
                    done = true;
                }
            }
        }

        private static void Swap<T>(ref T one, ref T two)
        {
            T temp = one;
            one = two;
            two = temp;
        }
    }
}
