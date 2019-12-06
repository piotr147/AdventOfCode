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

            while(n < 0)
            {

                n = GetNumberInput("Enter day number or negative number to exit: ");

                switch (n)
                {
                    case 1:
                        var n2 = GetNumberInput("Enter task number or negative number to exit: ");
                        if (n2 == 1)
                            Day1.GetResult1("Input1_1");
                        else if (n2 == 2)
                            Day1.GetResult2("Input1_2.txt");
                        else
                            global::System.Console.WriteLine("There is not task " + n2 + " in day " + n);
                        break;
                }


            }
            

            

        }

        
        private static int GetNumberInput(string message)
        {
            Console.Write("\n\n" + message);

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
                    Console.Write("\nEnter valid number: ");
                }
            }

            Console.WriteLine();
        }

    }
}
