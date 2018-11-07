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
            Console.WriteLine("DOT Plot");
            Console.WriteLine();

            var valuesReader = new ValuesReader();
            var data = valuesReader.ReadValuesFromDataFile(FullPathToDataFile);

            var averageData = FindMean(data);

            for (int i = 10; i > 0; i--)
            {
                if(i != 10)Console.Write($" {i}|");
                else Console.Write($"{i}|");
                var count = data.Where(it => it == i);
                for (int j = 0; j < data.Length; j++)
                {
                    if (data[j] == i)
                    {
                        Console.Write("*");
                    }
                    else if (i == averageData)
                    {
                        Console.Write("-");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                   
                }


                Console.Write($"\n");
            }

            for (int i = 0; i < data.Length; i++)
            {
                Console.Write("=");
            }
        }

        public static int FindMean(int[] values)
        {
           return (int)values.Average(it => it);
        }
    }
}
