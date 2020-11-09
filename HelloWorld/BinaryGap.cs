using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorld
{
    public class BinaryGap
    {
        public int Solution(int n)
        {
            int res = 0;
            int min = 0;
            int max = 2147483647;

            string binary = Convert.ToString(n, 2);
            if (n > min && n <= max)
            {
                binary = binary.Replace("1", "|1|");

                string[] s = binary.Split('|');

                for (int i = 0; i <= s.Count() -1 ; i++)
                {
                    if (string.IsNullOrEmpty(s[i]) || i + 1 >= s.Count())
                        continue;


                        string anterior = s[i - 1];
                        string siguiente = s[i + 1];
                        if (anterior.Equals("1") && siguiente.Equals("1"))
                        {
                            if (res < s[i].Count())
                                res = s[i].Count();
                        }

                }
            }
            return res;
        }
    }
}
