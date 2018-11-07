using System;
using System.Linq;

namespace DotPlot
{
    class Program
    {
        // TODO: Replace this string value with the path to actual data file.
        private const string FullPathToDataFile = @"D:\PlayCode\quiz-plot\data\Values.Data.txt";

        static void Main(string[] args)
        {
            Console.WriteLine("DOT Plot");
            Console.WriteLine();
            
            var ValueReader = new ValuesReader();
            var data = ValueReader.ReadValuesFromDataFile(FullPathToDataFile);
            var mean = FindMean(data);

            for (int i = 10; i >= 0; i--)
            {
                if (i != 10)
                    Console.Write(" ");
                Console.Write($"{i} |");
                foreach (var item in data)
                {
                    if (item == i)
                        Console.Write("*");
                    else if (i == mean)
                        Console.Write("-");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("=====================================================");
            Console.ReadKey();
        }

        static int FindMean(int[] values)
        {
            return values.Sum() / values.Count();
        }
    }
}
