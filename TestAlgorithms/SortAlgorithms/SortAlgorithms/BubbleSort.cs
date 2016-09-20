using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortAlgorithms
{
    public class BubbleSort
    {
        // https://ru.wikipedia.org/wiki/Сортировка_пузырьком

        public static void Sort(int[] data)
        {
            bool next;

            for (int i = 0; i < data.Length; i++)
            {
                next = false;

                // Так как после каждого прохода наибольшее число всегда будет в конце,
                // то с каждым разом снижаем количество ходов на i.

                for (int j = 0; j < data.Length - i - 1; j++)
                {
                    if (data[j] > data[j + 1])
                    {
                        Swap(ref data[j], ref data[j + 1]);
                        next = true;
                    }
                }

                //foreach (var n in data)
                //{
                //    Console.Write("{0} ", n);
                //}

                //Console.WriteLine();

                if (!next)
                    break;
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
