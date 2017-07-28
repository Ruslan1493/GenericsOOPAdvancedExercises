using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4.GenericSwapMethodStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Box<string>> list = new List<Box<string>>();

            for (int i = 0; i < n;i++ )
            {
                list.Add(new Box<string>(Console.ReadLine()));
            }
            int[] indexes = Console.ReadLine().Split().Select(x=>int.Parse(x)).ToArray();
            listSwap(list, indexes[0], indexes[1]);

            foreach(var box in list)
            {
                Console.WriteLine(box);
            }

        }
        public static void listSwap<T>(List<Box<T>> listOfBoxes, int firstIndex, int secondIndex)
        {
            Box<T> value = listOfBoxes[firstIndex];
            listOfBoxes[firstIndex] = listOfBoxes[secondIndex];
            listOfBoxes[secondIndex] = value;
        }
       
    }
}
