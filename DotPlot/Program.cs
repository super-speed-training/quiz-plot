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

            for (int i = 10; i >= 0; i--)
            {
                Console.Write($"{i,4:G} |");
                for (int j = 0; j < values.Length; j++)
                {
                    if (i == values[j])
                    {
                        Console.Write("*");
                    }
                    else if (i == mean)
                    {
                        Console.Write("-");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine(new string('=', values.Length + 6));
        }

        static int FindMean(int[] values)
        {
            var mean = values.Sum() / values.Length;
            return mean;
        }
    }
}
