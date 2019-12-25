using System;
using System.IO;
using System.Linq;

namespace DotPlot
{
    class Program
    {
        // TODO: Replace this string value with the path to actual data file.
        private const string FullPathToDataFile = @"..\data\Values.Data.txt";

        static void Main(string[] args)
        {
            Console.WriteLine("DOT Plot");
            Console.WriteLine();

            // TODO: Implement quiz here
            try
            {
                // Open the text file using a stream reader.
                //     StreamReader sr = new StreamReader(FullPathToDataFile);
                //     // Read the stream to a string, and write the string to the console.
                //     String line = sr.ReadToEnd();
                //     Console.WriteLine(line);

                var reader = new ValuesReader();
                var values = reader.ReadValuesFromDataFile(FullPathToDataFile);
                var mean = FindMean(values);
              
                for (int i = 10; i >= 0; i--)
                {
                    Console.Write("{0,4:G} |", i);

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
                Console.Write(new String('=', values.Length));
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }

        static int FindMean(int[] values)
        {
            int mean = Convert.ToInt32(values.Average());
            return mean;
        }
    }
}
