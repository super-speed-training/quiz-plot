using System;
using System.Linq;

namespace DotPlot
{
    class Program
    {
        // TODO: Replace this string value with the path to actual data file.
        private const string FullPathToDataFile = @"../../../../data/Values.Data.txt";

        static void Main(string[] args)
        {
            var svc = new ValuesReader();
            var data = svc.ReadValuesFromDataFile(FullPathToDataFile);
            var average = FindMean(data);
            
            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine(data[i]);
            };
            // TODO: Implement quiz here
            Console.ReadLine();
        }
        static int FindMean(int[] values)
        {
            int valueAverage = 0;
            for (int i = 0; i < values.Length ; i++)
            {
                valueAverage += values[i];
            }
            return valueAverage / values.Length;            
        }

    }
}
