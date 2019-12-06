using System;
using System.Collections.Generic;
using System.Text;

namespace Advent.Helpers
{
    public static class Helper
    {
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
