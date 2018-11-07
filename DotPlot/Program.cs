using System;
using System.Linq;

namespace DotPlot
{
    class Program
    {
        private const string FullPathToDataFile = @"C:\Users\Mick\Desktop\quiz-plot\data\Values.Data.txt";
        static void Main(string[] args)
        {
            Console.WriteLine("DOT Plot");
            var reader = new ValuesReader();
            var values = reader.ReadValuesFromDataFile(FullPathToDataFile);
            var mean = FindMean(values);

            for (int i = values.Max(); i >= 0; i--)
            {
                if (i < 10)
                {
                    Console.Write(" ");
                }
                Console.Write(i + "  |");
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
            Console.WriteLine("==============================================");
        }

        static int FindMean(int[] values)
        {
            var mean = (int)values.Average();
            return mean;
        }
    }
}
