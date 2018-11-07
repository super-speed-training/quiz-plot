﻿using System;
using System.Linq;

namespace DotPlot
{
    class Program
    {
        // TODO: Replace this string value with the path to actual data file.
        private const string FullPathToDataFile = @"Values.Data.txt";

        static void Main(string[] args)
        {
            var reader = new ValuesReader();
            var values = reader.ReadValuesFromDataFile(FullPathToDataFile);

            var max = values.Max();
            var min = values.Min();
            var graphHight = max;
            var graphWidth = values.Count();

            var graph = new int[graphHight + 1, graphWidth];
            for (int i = 0; i < graphWidth; i++)
            {
                graph[max - values[i], i] = 1;
            }

            var mean = values.Sum() / values.Count();

            for (int i = 0; i < graphHight + 1; i++)
            {
                Console.Write($"{(graphHight - i).ToString(" 0 |")}");
                for (int j = 0; j < graphWidth; j++)
                {
                    if (graph[i, j] == 0 && i - 1 == mean)
                        Console.Write("-");
                    else if (graph[i, j] == 0)
                        Console.Write(" ");
                    else
                        Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
