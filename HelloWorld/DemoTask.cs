using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorld
{
    public class DemoTask
    {
        public int Solution(int [] a)
        {
            int res = 1;
            int min = -1000000;
            int max = 1000000;

            Array.Sort(a);

            for (int i = 0; i < a.Count(); i++)
            {
                if (res == a[i] && (a[i] >= min && a[i] <= 1000000))
                {
                    res++;
                    continue;
                }
                else
                {
                    res = i;
                }
            }

            return res;
        }
    }
}
