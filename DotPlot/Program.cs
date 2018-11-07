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
            var reader = new ValuesReader();
            var result = reader.ReadValuesFromDataFile(FullPathToDataFile);

            var max = result.Max();
            var average = (int)result.Average();

            for (int i = max; i >= 0; i--)
            {
                System.Console.Write($"{i} |");
                for (int j = 0; j < result.Length; j++)
                {
                    if (i == result[j])
                    {
                        System.Console.Write($"*");
                    }
                    else
                    {
                        if (average == i)
                        {
                            System.Console.Write("-");
                        }
                        else
                        {
                            System.Console.Write(" ");
                        }
                    }
                }
                System.Console.WriteLine();
            }

            for (int i = 0; i < result.Length + 3; i++)
            {
                System.Console.Write("=");
            }
            System.Console.WriteLine();
        }
    }
}
