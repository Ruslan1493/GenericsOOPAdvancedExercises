using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericsOOPAdvancedExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string str = Console.ReadLine();
            Box<string> first = new Box<string>(str);
            Box<int> second = new Box<int>(number);
            Console.WriteLine(first);
            Console.WriteLine(second);
        }
    }
}
