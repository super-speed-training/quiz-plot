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
            Console.WriteLine("*");
            var ValuesReader = new ValuesReader();
            var value = ValuesReader.ReadValuesFromDataFile(FullPathToDataFile);
            var findmean = FindMean(value);


            // TODO: Implement quiz here
        }
        static int FindMean(int[] values)
        {
           var findmean = values.Sum() / values.Length;
           return findmean;
        }
    }
}
