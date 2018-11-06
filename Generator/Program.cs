using System;
using System.Collections.Generic;
using System.IO;

namespace Generator
{
    class Program
    {
        const string FileName = "Values.Data.txt";

        static void Main(string[] args)
        {
            Console.WriteLine("Start generating values ...");

            var rdm = new Random();
            const int NumbersOfColumnToPlot = 40;
            var columnLeft = NumbersOfColumnToPlot;
            var values = new List<int>(NumbersOfColumnToPlot);

            do
            {
                var extendedLength = rdm.Next(4);
                var columnWidth = Math.Min(columnLeft, 4 + extendedLength);
                var seed = rdm.Next(10);

                for (int i = 0; i < columnWidth; i++)
                {
                    const double DistortedThreshold = 0.7;
                    if (rdm.NextDouble() > DistortedThreshold)
                    {
                        var distortedValue = (seed + 1 + rdm.Next(8)) % 10;
                        values.Add(distortedValue);
                    }
                    else
                    {
                        values.Add(seed);
                    }
                }

                columnLeft -= columnWidth;
            } while (columnLeft > 0);

            WriteValuesToFile(values, FileName);

            Console.WriteLine("Generated values have been written to '{0}'.", FileName);
        }

        static void WriteValuesToFile(IEnumerable<int> values, string fileName) {
            using (var fi = new StreamWriter(File.OpenWrite(fileName)))
            {
                foreach (var val in values)
                {
                    fi.WriteLine(val);
                }
                fi.Flush();
            }
        }
    }
}
