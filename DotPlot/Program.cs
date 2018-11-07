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
            var valuesReader = new ValuesReader();
            var values = valuesReader.ReadValuesFromDataFile(FullPathToDataFile);
            var mean = FindMean(values);

            for (int i = 10; i > 0; i--)
            {
                if (i < 10)
                {
                    System.Console.Write(" ");
                }
                Console.Write($"{i} |");
                for (int j = 0; j < values.Length; j++)
                {
                    if (i == values[j])
                    {
                        System.Console.Write("*");
                    }
                    else if (i == mean)
                    {
                        System.Console.Write("-");
                    }
                    else
                    {
                        System.Console.Write(" ");
                    }
                }
                System.Console.WriteLine();
            }

            // TODO: Implement quiz here
        }

        static int FindMean(int[] values)
        {
            var mean = values.Sum() / values.Length;
            return mean;
        }
    }
}
