using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    public class BalancedBrackets
    {
        /// <summary>
        /// Given n strings of brackets, determine whether each sequence of brackets is balanced. If a string is balanced, return YES. Otherwise, return NO.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string isBalanced(string s)
        {
            if (s.Length % 2 > 0)
                return "NO";

            int n = -1;

            while (s.Length != n)
            {
                n = s.Length;
                s = s.Replace("()", "");
                s = s.Replace("[]", "");
                s = s.Replace("{}", "");
            }


            if (s.Length == 0)
            {
                return "YES";
            }
            else
            {
                return "NO";
            }
        }
    }
}
