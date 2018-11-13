using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FailSoftArray
{
    class FailSoftArray
    {
        int[] a;
        int errval;

        public int Length;

        public FailSoftArray(int size, int errv)
        {
            a = new int[size];
            errval = errv;
            Length = size;
        }

        public int Get(int index)
        {
            if (Ok(index)) return a[index];
            return errval;
        }

        public bool Put(int index, int val)
        {
            if (Ok(index))
            {
                a[index] = val;
                return true;
            }
            return false;
        }

        private bool Ok(int index)
        {
            if (index >= 0 & index < Length) return true;
            return false;
        }

    }
}