using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericsOOPAdvancedExercises
{
    public class Box<T>
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
    }
}
