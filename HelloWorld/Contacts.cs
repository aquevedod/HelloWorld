using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorld
{
    public class Contacts
    {
        public List<int> contacts(List<List<string>> queries)
        {
            List<int> response = new List<int>();
            List<string> namesToSearch = new List<string>();
            foreach (List<string> item in queries)
            {
                if (item[1].Length >= 1 && item[1].Length <= 21)
                {
                    switch (item[0])
                    {
                        case "add":
                            namesToSearch.Add(item[1]);
                            break;
                        case "find":
                            int find = namesToSearch.Where(s => s.StartsWith(item[1])).Count();
                            response.Add(find);
                            break;
                        default:
                            break;
                    }
                }
            }

            return response;
        }
    }
}