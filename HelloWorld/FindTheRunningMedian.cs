using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorld
{
    public class FindTheRunningMedian
    {
        public decimal runningMedian(List<int> a)
        {
            if (a.Count == 1)
            {
                return a[0];
            }
            else
            {
                a.Sort();
                //si es par
                if (a.Count % 2 == 0)
                {
                    int half = a.Count / 2;
                    return (a[half] + a[half - 1]) / 2M;
                }
                else
                {
                    int half = (int)Math.Round(a.Count / 2M, 0, MidpointRounding.AwayFromZero);
                    return a[half - 1];
                }
            }

        }
    }
}
