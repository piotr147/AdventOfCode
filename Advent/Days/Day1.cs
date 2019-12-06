using System;
using System.Collections.Generic;
using System.Text;
using Advent.Helpers;

namespace Advent.Days
{
    public static class Day1
    {
        public static int GetResult1(List<int> data)
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

        public static int GetResult2(string fileName)
        {
            data = Helper.GetListFromFile(fileName);
            int result = 0;

            foreach (var number in data)
            {
                var moduleResult = 0;
                var mass = number;

                while(mass > 0)
                {
                    moduleResult += mass / 3 - 2;
                    mass = mass / 3 - 2;
                }
                result += moduleResult;
            }

            Console.WriteLine(result);
            return result;
        }


    }
}
