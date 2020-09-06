using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorld
{
    public class CountingValleys
    {
        public int countingValleys(int n, string s)
        {
            int output = 0;

            if (n < 2 && n > Math.Pow(10, 6))
                return output;

            int seaLevel = 0;
            int count = 0;

            List<string> lstSteps = s.Select(x => x.ToString()).ToList();
            if (lstSteps != null && lstSteps.Count > 0)
            {
                foreach (string item in lstSteps)
                {
                    if (item.Contains("U") || item.Contains("D"))
                    {
                        switch (item)
                        {
                            case "D":
                                seaLevel--;
                                break;
                            case "U":
                                seaLevel++;
                                if (seaLevel == 0)
                                    count++;
                                break;
                            default:
                                break;
                        }
                    }
                    else
                    {
                        return output;
                    }
                }
            }
            else
            {
                return output;
            }
            return count;
        }
    }
}
