using System;
using System.Collections.Generic;
using System.Text;

namespace MyLIST
{
    class MyList<T>
    {
        private T[] list;
        public int Count = 0;

        public MyList()
        {
            list = new T[Count];
        }

        public void Add(T value)
        {
            Count++;
            T[] newList = new T[Count];

            for (int i = 0; i < Count - 1; i++)
            {
                newList[i] = list[i];
            }

            newList[Count - 1] = value;
            list = newList;
        }

        public void AddRange(ICollection<T> collection)
        {
            Count += collection.Count;
            T[] collectionList = collection as T[];
            T[] newList = new T[Count];

            for (int i = 0; i < list.Length; i++)
            {
                newList[i] = list[i];
            }

            int j = list.Length;
            for (int i = 0; i < collectionList.Length; i++)
            {
                newList[j] = collectionList[i];
                j++;
            }

            list = newList;
        }

        public int IndexOf(T item)
        {
            dynamic dynamicItem = item;
            dynamic a;
            int index = 0;

            for (int i = 0; i < Count - 1; i++)
            {
                a = list[i];

                if (a == dynamicItem)
                {
                    index = i;
                    break;
                }
            }

            return index;
        }

        public void Insert(int index, T item)
        {
            Count++;
            T[] newList = new T[Count];

            for (int i = 0; i < index; i++)
            {
                newList[i] = list[i];
            }

            newList[index] = item;

            for (int j = index + 1; j < Count - 1; j++)
            {
                newList[j] = list[j];
            }

            newList[Count - 1] = list[Count - 2];

            list = newList;
        }

        public bool Remove(T item)
        {
            Count--;
            T[] newList = new T[Count];
            dynamic dynamicItem = item;
            dynamic a;
            int index = 0;
            bool check = false;

            for (int i = 0; i < Count; i++)
            {
                a = list[i];
                if (a == dynamicItem)
                {
                    index = i;
                    break;
                }
            }

            for (int i = 0; i < Count; i++)
            {
                if (i != index)
                {
                    newList[i] = list[i];
                }
                else
                {
                    newList[index] = list[i + 1];
                }
            }
            

            list = newList;
            return check;
        }

        public void RemoveAt(int index)
        {
            Count--;
            T[] newList = new T[Count];

            for (int i = 0; i < Count; i++)
            {
                if (i != index)
                {
                    newList[i] = list[i];
                }
                else
                {
                    newList[index] = list[i + 1];
                }
            }

            list = newList;
        }

        public void Sort()
        {
            Array.Sort<T>(list, 0, list.Length);
        }

        public void ChangeMin()
        {
            dynamic min = 0;
            int indexMin = 0;
            dynamic max = 0;
            int indexMax = 0;

            for (int i = 0; i < Count; i++)
            {
                if (min > list[i])
                {
                    min = list[i];
                    indexMin = i;
                }
                if (max < list[i])
                {
                    max = list[i];
                    indexMax = i;
                }
            }

            T temp = min;
            min = list[indexMax];
            list[indexMax] = temp;
            list[indexMin] = min;
        }

        public MyList<string> AllEq(MyList<string> listString)
        {
            int lengthStr = 0;

            for (int i = 0; i < listString.Count; i++)
            {
                if (lengthStr < listString.list[i].Length)
                {
                    lengthStr = listString.list[i].Length;
                }
            }

            for (int i = 0; i < listString.Count; i++)
            {
                while (listString.list[i].Length < lengthStr)
                {
                    listString.list[i] = listString.list[i] + "_";
                }
            }

            return listString;
        }

        public T this[int index]
        {
            get
            {
                return list[index];
            }
            set
            {
                if (index <= list.Length - 1)
                {
                    list[index] = value;
                }
                else
                {
                    Count = index + 1;
                    T[] newList = new T[Count];

                    for (int i = 0; i < list.Length; i++)
                    {
                        newList[i] = list[i];
                    }

                    newList[index] = value;
                    list = newList;
                }
            }
        }
    }
}
