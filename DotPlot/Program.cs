using System;
using System.Collections.Generic;
using System.Linq;

namespace DotPlot
{
    class Program
    {
        // TODO: Replace this string value with the path to actual data file.
        private const string FullPathToDataFile = @"Values.Data.txt";

        static void Main(string[] args)
        {
            var reader = new ValuesReader();
            var numbers = reader.ReadValuesFromDataFile($"..\\..\\..\\..\\data\\" + FullPathToDataFile);
            var lines = new List<string>()
            {
                " 0 |",
                " 1 |",
                " 2 |",
                " 3 |",
                " 4 |",
                " 5 |",
                " 6 |",
                " 7 |",
                " 8 |",
                " 9 |",
                "10 |",
            };

            var avg = (int)numbers.Average();
            foreach (var item in numbers)
            {
                lines[item] += "*";
                for (int i = 0; i < lines.Count; i++)
                {
                    if (i == item) continue;
                    if (i == avg)
                    {
                        lines[i] += "-";
                    }
                    else
                    {
                        lines[i] += " ";
                    }
                }
            }

            foreach (var item in lines.OrderByDescending(it => it))
            {
                Console.WriteLine(item);
            }
        }
    }
}
