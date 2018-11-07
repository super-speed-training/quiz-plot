using System;
using System.Linq;

namespace DotPlot
{
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
        private const string FullPathToDataFile = @"./../data/Values.Data.txt";

                static void Main(string[] args)
                {
                    // TODO: Implement quiz here
                    ValuesReader vr = new ValuesReader();
                    int[] arr = vr.ReadValuesFromDataFile(FullPathToDataFile);
                    int mean = FindMean(arr);

                    for (int i = 10; i >= 0; i--) {
                        Console.Write("{0, 3:G}|", i);
                        for (int j = 0; j < arr.Length; j++) {
                          if (i == arr[j])
                              Console.Write("*");
                          else if (i == mean)
                              Console.Write("-");
                          else
                              Console.Write(" ");
                        }
                        Console.Write("\n");
                        if (i == 0)
                            Console.WriteLine("  " + new String('=', arr.Length+10));
                    }
                }
            }
        }
