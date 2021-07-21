using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Amazon
{
    public class FreshPromo
    {
        public static int foo(List<List<string>> proList, List<string> order)
        {
            int ordInd = 0, proLsInd = 0;

            while (ordInd < order.Count)
            {

                List<string> pListItem = proList[proLsInd];
                int proLsItemind = 0;
                while (proLsItemind < pListItem.Count && ordInd < order.Count)
                {
                    if (pListItem[proLsItemind].Equals(order[ordInd]) || pListItem[proLsItemind].Equals("anything"))
                    {
                        proLsItemind++;
                    }
                    else
                    {
                        proLsItemind = 0;
                    }
                    ordInd++;
                }
                if (proLsItemind != pListItem.Count)
                    return 0;

                proLsInd++;
            }

            if (proLsInd < proList.Count)
                return 0;

            return 1;
        }
    }
}
