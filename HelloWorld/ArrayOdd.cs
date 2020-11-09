using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace HelloWorld
{
    public class ArrayOdd
    {
        public int Solution(int[] A)
        {

            int res = 0;

            if (A != null && A.Count() > 0)
            {
                if ((A.Count() % 2) == 0 && A.Count() <= 1000000)
                    return res;

                var results = (from a in A
                               group a by a into b
                               select new { key = b, cnt = b.Count() }).ToList();

                var res2 = results.Where(x => x.cnt == 1).Select(x => x.key).FirstOrDefault();

                if (res2 != null)
                    res = res2.Key;
            }

            return res;
        }
    }
}
