using System;
using System.Collections.Generic;
using System.Linq;

namespace _1_RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            var items = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i]<0)
                {
                    items.RemoveAt(i);
                    //когато трием листа се преподрежда и трябва да върнем итератора с 1 назад, защото иначе ще пропуснем един елемент
                    i--;
                }
            }
            items.Reverse();
            if (items.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", items));
            }
        }
    }
}
