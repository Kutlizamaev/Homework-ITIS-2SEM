using System;
using System.Collections.Generic;
using System.Text;

namespace TRAIN
{
    class Index
    {
        public Train[] data;
        public Index(int n)
        {
            data = new Train[n];
        }
        public Train this[int index]
        {
            get
            {
                return data[index];
            }
            set
            {
                data[index] = value;
            }
        }
    }
}
