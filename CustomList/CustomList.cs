using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomList
{
    public class CustomList<T> where T : IComparable<T>
    {
        public T value;
        private List<T> list = new List<T>();
        public CustomList()
        {
        }
        public CustomList(T value)
        {
            this.list.Add(value);
        }

        public void Add(T element)
        {
            this.list.Add(element);
        }
        public T Remove(int index)
        {
            T element = this.list.ElementAt(index);
            this.list.RemoveAt(index);
            return element;
        }

        public bool Contains(T element)
        {
            if(this.list.Contains(element))
            {
                return true;
            }
            return false;
        }

        public void Swap(int index1, int index2)
        {
            if (index1 >= 0 && index2 >= 0 && this.list.Count > index1 && this.list.Count > index2)
            {
                T elementOne = this.list.ElementAt(index1);
                T elementTwo = this.list.ElementAt(index2);
                this.list[index1] = elementTwo;
                this.list[index2] = elementOne;
            }
        }
        public int CountGreaterThan(T element)
        {
            int count = 0;
            for (int i = 0; i < this.list.Count; i++)
            {
                if (this.list[i].CompareTo(element) > 0)
                {
                    count++;
                }
            }

            return count;
        }

        public int CompareTo(T other)
        {
            if(this.value.CompareTo(other) > 0)
            {
                return 1;
            }
            else if (this.value.CompareTo(other) < 0)
            {
                return 1;
            }

            return 0;
        }
        public T Max()
        {
            T element = this.list[0];
            for (int i = 1; i < this.list.Count;i++ )
            {
                if(this.list[i].CompareTo(element) > 0)
                {
                    element = this.list[i];
                }
            }
            return element;
        }

        public T Min()
        {
            T element = this.list[0];
            for (int i = 1; i < this.list.Count; i++)
            {
                if (this.list[i].CompareTo(element) < 0)
                {
                    element = this.list[i];
                }
            }
            return element;
        }
        public int Count()
        {
            return this.list.Count();
        }

        public T this[int index]
        {
            get
            {
                return this.list[index];
            }
            set
            {
                this.list[index] = value;
            }
        }
    }
}
