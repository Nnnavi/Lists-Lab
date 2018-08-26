using System;
using System.Collections.Generic;
using System.Linq;

namespace _7_CountNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            //правим масив с размер колкото са самите числа - 1000, тоест индекса е самото число, а съдържанието на индекса е колко пъти се среща числото
            int[] arr = new int[1001];

            foreach (int num in numbers)
            {
                arr[num]++;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]!=0)
                {
                    Console.WriteLine("{0} -> {1}",i,arr[i]);
                }
            }
        }
    }
}
