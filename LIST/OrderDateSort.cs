using System;
using System.Collections.Generic;
using System.Text;

namespace LIST
{
    static class OrderDateSort
    {
        private static void Swap(List<string[]> list, int x, int y)
        {
            var temp = list[x];
            list[x] = list[y];
            list[y] = temp;
        }

        private static int Partition(List<string[]> list, int minIndex, int maxIndex)
        {
            int pivot = minIndex - 1;

            for (int i = minIndex; i < maxIndex; i++)
            {
                var dateFirst = DateTime.Parse(list[i][2]);
                var dateSecond = DateTime.Parse(list[maxIndex][2]);
                if (dateFirst > dateSecond)
                {
                    pivot++;
                    Swap(list, pivot, i);
                }
            }

            pivot++;
            Swap(list, pivot, maxIndex);

            return pivot;
        }

        private static List<string[]> QuickSort(List<string[]> list, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return list;
            }

            int pivotIndex = Partition(list, minIndex, maxIndex);
            QuickSort(list, minIndex, pivotIndex - 1);
            QuickSort(list, pivotIndex + 1, maxIndex);

            return list;
        }

        public static List<string[]> Sorting(List<string[]> list)
        {
            QuickSort(list, 0, list.Count - 1);

            return list;
        }
    }
}
