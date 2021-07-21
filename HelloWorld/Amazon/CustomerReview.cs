using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorld.Amazon
{
    public class CustomerReview
    {
        public static List<List<string>> searchSuggestions(List<string> repository, string customerQuery)
        {
            List<List<string>> response = new List<List<string>>();
            List<string> subResponse = new List<string>();
            int lengthSearch = 2;

            for (int i = 0; i < customerQuery.Length - 1; i++)
            {
                string wordToSearch = customerQuery.Substring(0, lengthSearch);
                subResponse = repository.Where(x => x.Contains(wordToSearch)).ToList();

                if (subResponse.Count > 0)
                {
                    subResponse.ForEach(s => s.ToLower());
                    response.Add(subResponse.Take(3).ToList());
                }


                lengthSearch++;
            }
            
            return response;
        }
    }
}
