using System;
﻿using static System.Console;
using System.Linq;
using System.Collections.Generic;
using System.IO;

namespace DotPlot
{
  public class ValuesReader {
      public int[] ReadValuesFromDataFile(string fullPathToFile) {
          using (var fi = File.OpenText(fullPathToFile))
          {
              var values = new List<int>();
              string line;
              while ((line = fi.ReadLine()) != null)
              {
                  if (!string.IsNullOrWhiteSpace(line))
                  {
                      values.Add(int.Parse(line));
                  }
              }

              return values.ToArray();
          }
      }
  }

    class Program
    {
        static int FindMean(int[] values) {
            int sum = 0;
            for (int i = 0; i < values.Length; i++) {
                sum += values[i];
            }

            return sum / values.Length;
        }
        // TODO: Replace this string value with the path to actual data file.
        private const string FullPathToDataFile = @"./data/Values.Data.txt";

        static void Main(string[] args)
        {
            ValuesReader vr = new ValuesReader();
            int[] arr = vr.ReadValuesFromDataFile(FullPathToDataFile);
            //Console.WriteLine(FindMean(arr));

            for (int i = 0; i <= 10; i++) {
              for (int j = 0; j <= 10; j++) {
                if (FindMean(arr) == i) Write("-");
                if (j == 0) Write(10 - i);
                if (i == arr[j]) Write("*");
                else Write(" ");
              }
              WriteLine("");
            }

            // TODO: Implement quiz here
        }
    }
}
