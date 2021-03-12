using System;
using System.Collections.Generic;
using System.Text;

namespace INDEXER
{
    class Array
    {
        private int[,] arr;
        public int sizeString;
        public int sizeColomn;

        public Array(int x, int y)
        {
            sizeString = x;
            sizeColomn = y;

            arr = new int[x, y];
        }

        public void ArrayElem()
        {
            for (int i = 0; i < sizeString; i++)
            { 
                for(int j=0;j<sizeColomn;j++)
                {
                    Console.Clear();
                    Console.Write("Введите элемент массива: ");
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        public void InputArray()
        {
            Console.Clear();
            for (int i = 0; i < sizeString; i++)
            {
                for (int j = 0; j < sizeColomn; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public int this[int x, int y]
        {
            get 
            {
                return arr[x, y];
            }
            set
            {
                arr[x, y] = value;
            }
        }

        public int this[int colomn]
        {
            get
            {
                for (int i = 0; i < sizeString; i++)
                {
                    Console.WriteLine(arr[i, colomn]);
                }
                return 0;
            }
            set
            {
                for (int i = 0; i < sizeString; i++)
                {
                    arr[i, colomn] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
    }
}
