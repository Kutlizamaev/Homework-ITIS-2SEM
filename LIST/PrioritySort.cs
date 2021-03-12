using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace LIST
{
    static class PrioritySort
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
                switch(list[i][3])
                {
                    case "Critical":
                        if (list[maxIndex][3] == "Not Specified" || list[maxIndex][3] == "Low" || list[maxIndex][3] == "Medium" || list[maxIndex][3] == "High")
                        {
                            pivot++;
                            Swap(list, pivot, i);
                        }
                        break;
                    case "High":
                        if (list[maxIndex][3] == "Not Specified" || list[maxIndex][3] == "Low" || list[maxIndex][3] == "Medium")
                        {
                            pivot++;
                            Swap(list, pivot, i);
                        }
                        break;
                    case "Medium":
                        if (list[maxIndex][3] == "Not Specified" || list[maxIndex][3] == "Low")
                        {
                            pivot++;
                            Swap(list, pivot, i);
                        }
                        break;
                    case "Low":
                        if (list[maxIndex][3] == "Not Specified")
                        {
                            pivot++;
                            Swap(list, pivot, i);
                        }
                        break;
                    case "Not Specified":
                        break;
                    default:
                        break;
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
