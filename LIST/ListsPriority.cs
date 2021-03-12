using System;
using System.Collections.Generic;
using System.Text;

namespace LIST
{
    static class ListsPriority
    {
        public static List<string[]> SortPriority(List<string[]> list)
        {
            List<string[]> CriticalLists = new List<string[]>();
            List<string[]> HighLists = new List<string[]>();
            List<string[]> MediumLists = new List<string[]>();
            List<string[]> LowLists = new List<string[]>();
            List<string[]> NotSpecifiedLists = new List<string[]>();

            for (int i = 0; i < list.Count; i++)
            {
                switch (list[i][3])
                {
                    case "Critical":
                        CriticalLists.Add(list[i]);
                        break;
                    case "High":
                        HighLists.Add(list[i]);
                        break;
                    case "Medium":
                        MediumLists.Add(list[i]);
                        break;
                    case "Low":
                        LowLists.Add(list[i]);
                        break;
                    case "Not Specified":
                        NotSpecifiedLists.Add(list[i]);
                        break;
                }
            }

            CriticalLists = DateSort.Sorting(CriticalLists);
            HighLists = DateSort.Sorting(HighLists);
            MediumLists = DateSort.Sorting(MediumLists);
            LowLists = DateSort.Sorting(LowLists);
            NotSpecifiedLists = DateSort.Sorting(NotSpecifiedLists);

            List<string[]> returnedList = CriticalLists;
            returnedList.AddRange(HighLists);
            returnedList.AddRange(MediumLists);
            returnedList.AddRange(LowLists);
            returnedList.AddRange(NotSpecifiedLists);

            return returnedList;
        }
    }
}
