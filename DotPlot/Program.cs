using System;
using System.Linq;

namespace DotPlot
{
    class Program
    {
        // TODO: Replace this string value with the path to actual data file.
        private const string FullPathToDataFile = @"F:\Git\quiz-plot\data\Values.Data.txt";

        static void Main(string[] args)
        {
            var svc = new ValuesReader();
            var data = svc.ReadValuesFromDataFile(FullPathToDataFile);
            var average = FindMean(data);

            for (int vectorY = 10; vectorY >= 0; vectorY--)
            {
                Console.Write($"{vectorY,4:G}"+"|");
                for (int vectorX = 0; vectorX < data.Length; vectorX++)
                {
                    if (data[vectorX] == vectorY)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        if(vectorY == average)
                        {
                            Console.Write("-");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
                Console.Write("\n");
            }
            Console.Write(new String('=', data.Length+5));
            Console.ReadLine();
        }
        static int FindMean(int[] values)
        {
            int valueAverage = 0;
            for (int i = 0; i < values.Length ; i++)
            {
                valueAverage += values[i];
            }
            return valueAverage / values.Length;            
        }
    }
}
