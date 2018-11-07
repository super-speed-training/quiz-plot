using System;
using System.Linq;

namespace DotPlot
{
    class Program
    {
        private const string FullPathToDataFile = @"../../../../data/Values.Data.txt";

        static void Main(string[] args)
        {
            var svc = new ValuesReader();
            var data = svc.ReadValuesFromDataFile(FullPathToDataFile);
            var avr = data.Sum() / data.Length;
            Console.WriteLine("DOT Plot");
            Console.WriteLine();

            for (int i = 10; i >= 0; i--)
            {
                Console.Write($"{i} \t| ");

                for (int j = 0; j < data.Length; j++)
                {
                    if (data[j] == i)
                    {
                        Console.Write("*");
                    }
                    else if (i == avr)
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

            Console.WriteLine("==================================================");
        }
    }
}
