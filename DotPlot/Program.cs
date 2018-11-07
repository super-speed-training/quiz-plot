using System;
using System.Linq;

namespace DotPlot
{
    public class Program
    {
        // TODO: Replace this string value with the path to actual data file.
        private const string FullPathToDataFile = @"Values.Data.txt";


        static void Main(string[] args)
        {
            // TODO: Implement quiz here
            Console.WriteLine("DOT Plot");
            Console.WriteLine();
            var ValuesReader = new ValuesReader();
            var datas = ValuesReader.ReadValuesFromDataFile(FullPathToDataFile);
        }
        static int FindMean(int[] values){
            var avg = values.Average();

            return 0;
        }
    }
}
