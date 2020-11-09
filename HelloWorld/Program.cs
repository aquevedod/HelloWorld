using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //CallhackerCard();
            //CallSockMerchant();
            //countingValleys();
            //DemoTask();
            //BinaryGap();
            //RotateArray();
            //ArrayOdd();
            //FrogJump();
            //SouthWorkChallenge();
            Solution(54321);
        }

        private static void countingValleys()
        {
            var obj = new CountingValleys();
            int v = obj.countingValleys(8, "UDDDUDUU");

            Console.WriteLine(v);
        }

        private static void CallSockMerchant()
        {
            var obj = new SockMerchant();
            int[] ar = new int[] { 1, 2, 1, 2, 1, 3, 2 };
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

        private static void DemoTask()
        {
            var obj = new DemoTask();
            int[] arrayInt = new int[] { 1, 2, 3 };
            Console.WriteLine(obj.Solution(arrayInt));
        }

        private static void BinaryGap()
        {
            var obj = new BinaryGap();
            int res = obj.Solution(32);
            Console.WriteLine(res);
        }

        private static void RotateArray()
        {
            var obj = new RotateArray(); ;
            int[] res = obj.Solution(new int[] { 1, 1, 2, 3, 5 }, 42);

            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
        }

        private static void ArrayOdd()
        {
            var obj = new ArrayOdd();
            Random rd = new Random();
            int[] arr = new int[999999];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rd.Next(1, 1000000000);
            }


            int res = obj.Solution(arr);

            Console.WriteLine(res);
        }


        private static void FrogJump()
        {
            var obj = new FrogJump();
            //int res = obj.Solution(10, 85, 30);
            int res = obj.Solution(3, 999111321, 7);
            Console.WriteLine(res);
        }

        private static void SouthWorkChallenge()
        {
            var obj = new SouthWorkChallenge();
            string res = obj.Solution("askljhfdaskljfhaklsfhakljsdhFLKAHJFKLJDHFKDLJAHFALKFHAKLFHLADKkjlhfdalkahflkafhalkfjhdalkjfhalkDLKASJHFLKHFLKSDJFHALKJFHLAKJFHLAKFHALKFHALKDSJFHALKJFHA");
            Console.WriteLine(res);
        }

        private static void Solution(int N)
        {
            int enable_print = N % 10;
            while (N > 0)
            {
                if (enable_print == 0 && N / 10 != 0)
                {
                    enable_print = 1;
                }
                else if (enable_print == 1)
                {
                    Console.Write(N % 10);
                }
                N = N / 10;
            }
        }
    }
}
