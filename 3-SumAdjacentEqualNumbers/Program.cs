using System;
using System.Collections.Generic;
using System.Linq;

namespace _3_SumAdjacentEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
            // важно е да започва от 1, защото после от индекса вадим 1
            for (int i = 1; i < input.Count; i++)
            {
                if (input[i-1] == input[i])
                {
                   
                    input[i - 1] += input[i];
                    input.RemoveAt(i);
                    i = i - 2;
                    if (i<0)
                    {
                        i = 0;
                    }
                    
                    
                }
                      
                
            }
            Console.WriteLine(String.Join(" ", input));
        }
    }
}
