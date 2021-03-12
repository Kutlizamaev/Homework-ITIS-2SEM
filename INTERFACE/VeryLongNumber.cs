using System;

namespace INTERFACE
{
    class VeryLongNumber : INumber
    {
        public int num { get; set; }
        public string strNum;

        public INumber Add(INumber n)
        {
            this.strNum = (this.num + n.num).ToString();
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
                this.strNum = (this.num - n.num).ToString();
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
