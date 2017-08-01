using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomList
{
    public static class Sorter<T> where T : IComparable<T>
    {
        public static void Sort(CustomList<T> list)
        {
            for (int j = 0; j < list.Count(); j++)
            {
                T element = list[0];
                for (int i = 1; i < list.Count(); i++)
                {
                    if (list[i].CompareTo(element) < 0)
                    {
                        T copy = new CustomList<T>(list[i])[0];
                        list[i] = new CustomList<T>(element)[0];
                        list[i - 1] = new CustomList<T>(copy)[0];
                        element = new CustomList<T>(list[i])[0];
                    }
                }
            }
        }
    }
}
