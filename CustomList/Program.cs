using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<string> list = new CustomList<string>();
            //list.Add("aa");
            //list.Add("cc");
            //list.Add("bb");
            //list.Add("z");
            //string a = "bb";
            //Console.WriteLine(list.Max());

            string[] command = Console.ReadLine().Split();
            while(command[0] != "END")
            {
                switch(command[0])
                {
                    case "Add":
                        list.Add(command[1]);
                        break;
                    case "Remove":
                        list.Remove(int.Parse(command[1]));
                        break;
                    case "Contains":
                        Console.WriteLine(list.Contains(command[1]));
                        break;
                    case "Swap":
                        list.Swap(int.Parse(command[1]), int.Parse(command[2]));
                        break;
                    case "Greater":
                        Console.WriteLine(list.CountGreaterThan(command[1]));
                        break;
                    case "Max":
                        Console.WriteLine(list.Max());
                        break;
                    case "Min":
                        Console.WriteLine(list.Min());
                        break;
                    case "Sort":
                        Sorter<string>.Sort(list);
                        break;
                    case "Print":
                        for (int i = 0; i < list.Count();i++ )
                        {
                            Console.WriteLine(list[i]);
                        }
                        break;
                    default:
                        break;
                }
                command = Console.ReadLine().Split();
            }
        }
    }
}
