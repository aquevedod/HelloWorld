using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace HelloWorld
{
    public class SouthWorkChallenge
    {
        public string Solution(string S)
        {
            string res = "NO";

            if (string.IsNullOrEmpty(S) || S.Length < 1 || S.Length > 200000)
                return res;

            if (!Regex.IsMatch(S, @"^[a-zA-Z]+$"))
                return res;

            var lowers = new string(S.Distinct().Where(l => char.IsLower(l)).OrderBy(s => s).ToArray());
            var uppers = new string(S.Distinct().Where(u => char.IsUpper(u)).OrderBy(s => s).ToArray());

            var commonLetters = (from l in lowers
                                 join u in uppers.ToLower() on l equals u
                                 select l).ToArray();

            if (commonLetters != null && commonLetters.Count() > 0)
            {
                res = commonLetters[commonLetters.Length - 1].ToString().ToUpper();
            }


            return res;
        }


    }
}
