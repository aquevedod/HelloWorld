using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //CallhackerCard();
            CallSockMerchant();
        }

        private static void CallSockMerchant()
        {
            var obj = new SockMerchant();
            int[] ar = new int[] { 1,2,1,2,1,3,2 };
            int n = 7;

            int res = obj.sockMerchant(n, ar);

            Console.WriteLine(res.ToString());
            Console.ReadLine();
        }

        private static void CallhackerCard()
        {
            var obj = new BirthDayCard();
            int[] collectionLeanne = new int[] { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };

            int[] nuevoArray = obj.hackerCard(collectionLeanne, 20);

            if (nuevoArray != null && nuevoArray.Length > 0)
            {
                foreach (int item in nuevoArray)
                {
                    Console.WriteLine(item.ToString());
                }
                Console.ReadLine();
            }
        }
    }
}
