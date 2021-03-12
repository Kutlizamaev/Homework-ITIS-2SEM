using System;

namespace INTERFACE
{
    class Number : INumber
    {
        public int num { get; set; }

        public INumber Add(INumber n)
        {
            this.num += n.num;
            return this;
        }

        public INumber Sub(INumber n)
        {
            if (this.num - n.num < 0)
            {
                throw NotNaturalNumberException();
            }
            else
            {
                this.num -= n.num;
                return this;
            }
        }

        public int CompareTo(INumber n)
        {
            if (this.num == n.num)
            {
                return 0;
            }
            else
            {
                return this.num > n.num ? 1 : -1;
            }
        }

        public static Exception NotNaturalNumberException()
        {
            Exception n = new Exception("Number must be natural.");
            return n;
        }
    }
}
