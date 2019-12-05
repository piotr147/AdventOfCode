using System;
using System.Collections.Generic;
using System.Text;

namespace Advent.Days
{
    public static class Day1
    {
        public static int GetResult(List<int> data)
        {
            int result = 0;
            //var data = Helper.GetNumbersFromFile("Input1.txt");

            foreach (var number in data)
            {
                result += number / 3 - 2;
            }

            Console.WriteLine(result);
            return result;
        }
    }
}
