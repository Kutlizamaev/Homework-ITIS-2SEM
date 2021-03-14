using System;

namespace GENERICS
{
    class Program
    {
        static void Main(string[] args)
        {
            Number<string> n = new Number<string>();
            n.num = "30";
            Number<string> n2 = new Number<string>();
            n2.num = "20";
            n.Sub(n2);
            Console.WriteLine(n.num);
        }
    }
}
