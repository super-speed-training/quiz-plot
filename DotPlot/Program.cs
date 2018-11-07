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
            var reader = valuesReader.ReadValuesFromDataFile(FullPathToDataFile);
            var IsMean = FindMean(reader);
            for (int i = 10; i >= 0; i--)
            {
                // Console.Write(i + " |");
                Console.Write("{0,2:G} |",i);
                for (int j = 0; j < reader.Length; j++)
                {
                    if (reader[j] == i)
                    {
                        Console.Write("*");
                    }
                    else if (i == IsMean)
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
            // Console.WriteLine(new string('=',reader.Length + 10));
            Console.WriteLine("==============================================");
        }

        static int FindMean(int[] values)
        {
            int sum = 0;
            int mean;
            for (int i = 0; i < values.Length; i++)
            {
                sum += values[i];
            }
            mean = sum / values.Length;
            return mean;
        }
    }
}
