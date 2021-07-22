using System;
using System.Collections.Generic;
using System.Linq;
using static HelloWorld.ContactTrie;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //string option = Console.ReadLine();
            string option = "1";


            switch (option)
            {
                case "1":
                    DecodindString();
                    break;
                default:
                    break;
            }
            //CallhackerCard();
            //CallSockMerchant();
            //countingValleys();
            //DemoTask();
            //BinaryGap();
            //RotateArray();
            //ArrayOdd();
            //FrogJump();
            //SouthWorkChallenge();
            //Solution(54321);
            //isBalanced();
            //contacts();
            //TrieContact();
            //Median();
            //FreshPromo();

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

        private static void isBalanced()
        {
            BalancedBrackets balanced = new BalancedBrackets();
            string s = balanced.isBalanced("{([)]}");
            Console.WriteLine(s);
        }

        private static void contacts()
        {
            Contacts c = new Contacts();
            //int queriesRows = Convert.ToInt32(Console.ReadLine().Trim());
            List<List<string>> queries = new List<List<string>>();
            queries.Add("add hack".TrimEnd().Split(' ').ToList());
            queries.Add("add hackerrank".TrimEnd().Split(' ').ToList());
            queries.Add("find hac".TrimEnd().Split(' ').ToList());
            queries.Add("find hak".TrimEnd().Split(' ').ToList());
            //for (int i = 0; i < queriesRows; i++)
            //{
            //    queries.Add(Console.ReadLine().TrimEnd().Split(' ').ToList());
            //}
            List<int> result = c.contacts(queries);

            Console.WriteLine(string.Join("\n", result));
        }

        private static void TrieContact()
        {
            List<List<string>> queries = new List<List<string>>();
            ContactTrie trie = new ContactTrie();

            queries.Add("add hack".TrimEnd().Split(' ').ToList());
            queries.Add("add hackerrank".TrimEnd().Split(' ').ToList());
            queries.Add("find hac".TrimEnd().Split(' ').ToList());
            queries.Add("find hak".TrimEnd().Split(' ').ToList());

            var root = new TrieNode(char.MinValue, 0);
            List<int> response = new List<int>();

            foreach (var operation in queries)
            {
                var operationType = operation[0];
                var word = operation[1];
                if (operationType == "add")
                {
                    trie.AddTrieNode(root, word);
                }
                else
                {
                    var count = trie.GetWordCountFromTrie(root, word);
                    response.Add(count);
                }
            }
            foreach (int item in response)
            {
                Console.WriteLine(item);
            }
        }

        private static void Median()
        {
            int aCount = Convert.ToInt32(Console.ReadLine().Trim());
            FindTheRunningMedian f = new FindTheRunningMedian();
            List<int> a = new List<int>();
            List<decimal> response = new List<decimal>();
            for (int i = 0; i < aCount; i++)
            {
                int aItem = Convert.ToInt32(Console.ReadLine().Trim());
                a.Add(aItem);
                response.Add(f.runningMedian(a));
            }

            foreach (var item in response)
            {
                Console.WriteLine(item.ToString("0.0"));
            }
        }

        private static void CustomerReview()
        {
            List<string> repository = new List<string>() { "code", "codePhone", "coddle", "coddles", "codes" };
            string customerQuery = "coddle";
            Amazon.CustomerReview.searchSuggestions(repository, customerQuery);
        }

        private static void FreshPromo()
        {
            List<List<string>> _codeList = new List<List<string>>();
            List<string> codeList = new List<string>() { "orange", "apple apple", "banana orange apple", "banana" };
            List<string> shoppingCart = new List<string>() { "orange", "apple", "apple", "banana", "orange", "apple", "banana" };

            foreach (string item in codeList)
            {
                _codeList.Add(item.Split(' ').ToList());
            }
            int response = Amazon.FreshPromo.foo(_codeList, shoppingCart);
            Console.WriteLine(response);
        }

        private static void DecodindString()
        {
            int numberOfRows = 3;
            string encodedString = "mnes__ya_____mi";
            string result = Amazon.Encoding.decodeString(numberOfRows, encodedString);
        }
    }
}
