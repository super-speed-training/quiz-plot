using System;
using System.Linq;
using System.Text;

namespace DotPlot
{
    class Program
    {
        //Replace this string value with the path to actual data file.
        private const string FullPathToDataFile = @"D:\sirinarin\lab\quiz-plot\data\Values.Data.txt";

        static void Main(string[] args)
        {
            Console.WriteLine("DOT Plot");
            Console.WriteLine();

            // TODO: Implement quiz here
            var vr = new ValuesReader();
            var inputs = vr.ReadValuesFromDataFile(FullPathToDataFile);

            var mean = FindMean(inputs);

            for (int i = 10; i >= 0; i--)
            {
                var line = new StringBuilder();
                line.Append(string.Format("{0} |", i));
                for (int j = 0; j < inputs.Length; j++)
                {
                    if (i == mean)
                    {
                        line.Append("-");
                    }
                    if (inputs[j] == i)
                    {
                        line.Append("*");
                    }
                    else if(i != mean)
                    {
                        line.Append(" ");
                    }
                }
                Console.WriteLine(line.ToString());
            }
        }

        static int FindMean(int[] values)
        {
            return values.Sum() / values.Count();
        }
    }
}
