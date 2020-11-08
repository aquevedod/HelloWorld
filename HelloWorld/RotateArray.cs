using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorld
{
    public class RotateArray
    {
        public int[] Solution(int[] A, int K)
        {
            List<int> lA = new List<int>(A);

            if (K >= 0 && K <= 1000 && A.Count() >= 0 && A.Count() <= 1000)
            {
                if (lA != null && lA.Count > 0)
                {
                    for (int i = 0; i < lA.Count; i++)
                    {
                        if (lA[i] <= -1000 && lA[i] >= 1000)
                        {
                            return lA.ToArray();
                        }
                    }
                    for (int i = 0; i <= K - 1; i++)
                    {
                        int last = lA[lA.Count - 1];
                        lA.RemoveAt(A.Length - 1);
                        lA.Insert(0, last);
                    }
                }
            }

            return lA.ToArray();
        }
    }
}
//nl