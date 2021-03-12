using System;

namespace INTERFACE
{
    class Program
    {
        static void Main(string[] args)
        {
            Number n = new Number();
            Number a = new Number();
            
            n.num = 10;
            a.num = 50;
            a.Sub(n);
        }
    }
}
