using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5.GenericCountMethodStrings
{
    public class Box<T>:IComparable<T>
    {
        private T value;

        public Box(T value)
        {
            this.value = value;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(value.ToString());
            string currentClass = this.value.GetType().FullName;
            sb.Insert(0, currentClass + ": ");
            return sb.ToString();
        }

        public int CompareTo(T other)
        {
            if (this.value > other)
            {
                return 1;
            }
            else if (this.value < other)
            {
                return -1;
            }
            return 0;
        }

    }
}
