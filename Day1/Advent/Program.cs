using System;
using System.Collections.Generic;
using System.IO;
using Advent.Days;

namespace Advent
{
    class Program
    {
        static void Main(string[] args)
        {
            bool success = false;
            int n = 0;

            Console.Write("Enter day number: ");

            while (!success)
            {
                try
                {
                    success = true;
                    string day = Console.ReadLine();
                    n = Int32.Parse(day);
                }
                catch (Exception e)
                {
                    success = false;
                    Console.Write("\nEnter valid day number: ");
                }
            }

            Console.WriteLine();

            switch (n)
            {
                case 1:
                    var data = GetListFromFile(@"..\..\..\Input\Input1.txt");
                    Day1.GetResult(data);
                    break;
            }

        }

        public static List<int> GetListFromFile(string fileName)
        {
            var list = new List<int>();
            int fuel = 0;

            using (StreamReader sr = new StreamReader("Input.txt"))
            {
                String line = sr.ReadLine();

                while (line != null)
                {
                    list.Add(Int32.Parse(line));
                    line = sr.ReadLine();
                }
            }

            return list;
        }
    }
}
