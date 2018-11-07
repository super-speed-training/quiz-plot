using System;
using System.Linq;

namespace DotPlot
{
    public class Program
    {
        // TODO: Replace this string value with the path to actual data file.
        private const string FullPathToDataFile = @"../data/Values.Data.txt";

        static void Main(string[] args)
        {
            // TODO: Implement quiz here
            Console.WriteLine("DOT Plot");
            Console.WriteLine();
            var ValuesReader = new ValuesReader();
            var datas = ValuesReader.ReadValuesFromDataFile(FullPathToDataFile);
            var avg = datas.Sum() / datas.Length;
            // foreach (var item in datas)
            // {
            //     Console.WriteLine(item);
            // }
            // Console.WriteLine("avg" + avg);
            for (int i = 10; i >= 0; i--)
            {
                Console.Write($"{i} \t| ");
                for (int j = 0; j < datas.Length; j++)
                {
                    if (datas[j] == i)
                    {
                        Console.Write("*");
                    }
                    else if (i == avg)
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
            Console.WriteLine("\t" + new String('=', datas.Length));

        }

    }
}
