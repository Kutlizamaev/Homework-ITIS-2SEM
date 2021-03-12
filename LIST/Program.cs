using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace LIST
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Fanil\source\repos\Homework ITIS 2SEM\LIST\Sample.txt";
            List<string> list = new List<string>();
            List<string[]> arraysList = new List<string[]>();

            using (StreamReader sr = new StreamReader(path))
            {
                int count = 0;
                while (count < 150)
                {
                    count++;
                    list.Add(sr.ReadLine());
                }
            }

            for (int i = 0; i < list.Count; i++)
            {
                arraysList.Add(list[i].Split(';'));
            }

            Console.Write("Сортировки:\n1. По приоритету заказа.\n2. По дате принятия заказа.\n3. По дате прибытия заказа.\n");
            Console.Write("Введите: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    arraysList = PrioritySort.Sorting(arraysList);
                    break;
                case 2:
                    arraysList = OrderDateSort.Sorting(arraysList);
                    break;
                case 3:
                    arraysList = ShipDateSort.Sorting(arraysList);
                    break;
                default:
                    break;
            }

            Output(arraysList);
        }

        public static void Output(List<string[]> list)
        {
            int maxLengthName = 0;
            int maxLengthOrderDate = 0;
            int maxLengthShipDate = 0;
            int maxLengthPriority = 0;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i][17].Length > maxLengthName)
                { maxLengthName = list[i][17].Length; }
                if (list[i][2].Length > maxLengthOrderDate)
                { maxLengthOrderDate = list[i][2].Length; }
                if (list[i][20].Length > maxLengthShipDate)
                { maxLengthShipDate = list[i][20].Length; }
                if (list[i][3].Length > maxLengthPriority)
                { maxLengthPriority = list[i][3].Length; }
            }

            var formatName = string.Format("{{0, -{0}}}|", maxLengthName);
            var formatOrderDate = string.Format("{{0, -{0}}}|", maxLengthOrderDate);
            var formatShipDate = string.Format("{{0, -{0}}}|", maxLengthShipDate);
            var formatPriority = string.Format("{{0, -{0}}}|", maxLengthPriority);
            bool a = true;

            for (int i = 0; i < 150; i++)
            {
                while (a == true)
                {
                    Console.Write(formatName,list[i][17]);
                    Console.Write(" ");
                    Console.Write(formatOrderDate,list[i][2]);
                    Console.Write(" ");
                    Console.Write(formatShipDate,list[i][20]);
                    Console.Write(" ");
                    Console.Write(formatPriority,list[i][3]);
                    a = false;
                }

                a = true;
                Console.WriteLine();
            }
        }
    }
}
