using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            CallhackerCard();
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
