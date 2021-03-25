using System;
using System.Collections.Generic;

namespace MyLIST
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> a = new MyList<string>();

            //Indexer

            a[0] = "aaa";

            //Add

            a.Add("aaa");

            //AddRange

            string[] b = new string[3];
            b[0] = "bbb";
            a.AddRange(b);

            //IndexOf

            //int index = a.IndexOf("aaa");

            //Insert

            //a.Insert(1, "bbb");

            //Remove

            //bool b = a.Remove("aaa");

            //RemoveAt

            //a.RemoveAt(2);

            //AllEq

            //a = a.AllEq(a);

            //Sort

            //a.Sort();
        }
    }
}
