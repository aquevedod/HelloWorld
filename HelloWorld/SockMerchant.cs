using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorld
{
    public class SockMerchant
    {
        public int sockMerchant(int n, int[] ar)
        {
            int pair = 0;

            if (n < 1 && n > 100)
                return pair;

            if (ar != null && ar.Length > 0 && ar.Length <= 100)
            {
                Array.Sort(ar);
                int a = 0;
                int b = 0;
                for (int i = 0; i < ar.Length; i++)
                {
                    if (i >= 0 && i < n)
                    {
                        a = ar[i];
                        if (i < ar.Length - 1)
                        {
                            b = ar[i + 1];
                        }
                        else
                        {
                            break;
                        }
                        if (a == b)
                        {
                            pair++;
                            i = i + 1;
                        }
                    }
                }
            }
            return pair;
        }
    }
}
