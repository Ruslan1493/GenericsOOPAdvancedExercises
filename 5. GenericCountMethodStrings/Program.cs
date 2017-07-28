using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5.GenericCountMethodStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Box<string>> list = new List<Box<string>>();

            for (int i = 0; i < n; i++)
            {
                list.Add(new Box<string>(Console.ReadLine()));
            }
            //int[] indexes = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            string element = Console.ReadLine();
            Console.WriteLine(CountElements(list, element));
        }

        public static int CountElements<T>(List<Box<T>> list, T element)
        {
            int count = 0;
            for (int i = 0; i < list.Count;i++ )
            {
                if(list[i].CompareTo(element) > 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
