using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HelloWorld.Amazon
{
    public class Encoding
    {
        public static string decodeString(int numberOfRows, string encodedString)
        {
            string response = string.Empty;
            int sizeArray = encodedString.Length / numberOfRows;

            List<string> containerTemp = new List<string>();
            containerTemp = Split(encodedString, sizeArray).ToList();

            char[][] container = containerTemp.Select(x => x.ToArray()).ToArray();

            int i = 0, j = 0, k = 0;

            while(k < encodedString.Length)
            {
                while (i < numberOfRows)
                {
                    while (j < sizeArray)
                    {
                        response += container[i][j].ToString();
                        i++;
                        j++;
                    }
                    i = 0;
                    j = 1;
                }
                j = 1;
            }


            return response;
        }



        static IEnumerable<string> Split(string str, int size)
        {
            return Enumerable.Range(0, str.Length / size).Select(x => str.Substring(x * size, size));
        }
    }
}
