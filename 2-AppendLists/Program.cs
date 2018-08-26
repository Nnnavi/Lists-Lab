using System;
using System.Collections.Generic;
using System.Linq;

namespace _2_AppendLists
{
    class Program
    {
        static void Main(string[] args)
        {
            // създаваме масив от низове, идва от конзолата, разделя се, като се създават подмасиви от низове, в които се махат празните елементи
            string[] numbersWithSpaces = Console.ReadLine().Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            // обръщат се елементите в масива
            string[] reversed = numbersWithSpaces.Reverse().ToArray();
            //създаваме нов лист
            List<string> numbers = new List<string>();
            // за всеки елемент от обърнатия масив създаваме масив от низове, разцепени по празно пространство
            foreach (var item in reversed)
            {
                string[] numbersAsText = item.Split();

                foreach (var element in numbersAsText)
                {
                    //ако елемента не е празен го добавяме в крайния лист
                    if (element != "")
                    {
                        numbers.Add(element);
                    }
                }
            }
            //отпечатваме листа, като го набиваме в стринг
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}