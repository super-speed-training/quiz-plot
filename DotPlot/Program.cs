using System;
using System.Linq;

namespace DotPlot
{
    class Program
    {
        // TODO: Replace this string value with the path to actual data file.
        private const string FullPathToDataFile = @"../data/Values.Data.txt";

        static void Main(string[] args)
        {
            Console.WriteLine("DOT Plot");
            Console.WriteLine();

            // TODO: Implement quiz here
            ValuesReader val = new ValuesReader();
            var result = val.ReadValuesFromDataFile(FullPathToDataFile);

            foreach (var item in result)
            {
                System.Console.WriteLine(item);
            }
            var mean = FindMean(result);
        }

        static int FindMean(int[] values)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (i % 2 == 0)
                {

                }
            }

            return 0;
        }
    }
}
