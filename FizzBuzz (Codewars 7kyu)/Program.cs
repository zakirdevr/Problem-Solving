using System;
using System.Collections.Generic;

namespace FizzBuzz__Codewars_7kyu_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Solution(n);

            foreach (var item in Solution(n))
            {
                Console.Write(item+" ");
            }
        }
        public static int[] Solution(int number)
        {
            int[] arr = new int[3];
            List<int> myList = new List<int>();
            List<int> myList2 = new List<int>();
            List<int> myList3 = new List<int>();
            for (int i = 1; i <= number; i++)
            {
                if (i % 3 == 0 && i % 5 != 0 && i != number)
                {
                    myList.Add(i);
                }
                if (i % 5 == 0 && i % 3 != 0 && i != number)
                {
                    myList2.Add(i);
                }
                if (i % 3 == 0 && i % 5 == 0 && i != number)
                {
                    myList3.Add(i);
                }

            }
            arr[0] = myList.Count;
            arr[1] = myList2.Count;
            arr[2] = myList3.Count;

            return arr;
        }
    }
}
