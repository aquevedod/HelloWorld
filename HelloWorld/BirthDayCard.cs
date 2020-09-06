using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorld
{
    public class BirthDayCard
    {
        public int[] hackerCard(int[] collectionLeanne, int budgetMike)
        {
            int[] newCollection = null;
            _ = new List<int>();
            List<int> listLeanne = collectionLeanne.ToList();
            List<int> superList = new List<int>();

            double maxSizeCollection = Math.Pow(10, 9);

            try
            {
                if (budgetMike <= 0 && budgetMike > maxSizeCollection)
                    return newCollection;

                if (collectionLeanne != null && collectionLeanne.Length > 0 && collectionLeanne.Length <= maxSizeCollection)
                {
                    Array.Sort(collectionLeanne);

                    for (int i = 1; i <= budgetMike; i++)
                    {
                        superList.Add(i);
                    }
                    superList = RemoveValues(collectionLeanne, superList);
                    List<int> newCollectionList = CalculateValues(superList, budgetMike);
                    //listLeanne.AddRange(newCollectionList);
                    //listLeanne.Sort();
                    newCollection = newCollectionList.ToArray();
                }
                else
                {
                    newCollection = null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return newCollection;
        }

        private List<int> RemoveValues(int[] list1, List<int> list2)
        {
            foreach (int item in list1)
            {
                list2.Remove(item);
            }
            return list2;
        }

        private List<int> CalculateValues(List<int> listCaculated, int budget)
        {
            int mount = 0;
            List<int> finalList = new List<int>();
            foreach (int item in listCaculated)
            {
                mount = mount + item;

                if (mount <= budget)
                {
                    finalList.Add(item);
                    continue;
                }
                else
                {
                    break;
                }
            }
            return finalList;
        }
    }
}
