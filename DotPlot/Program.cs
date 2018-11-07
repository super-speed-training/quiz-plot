using System;
using System.Linq;



namespace DotPlot
{
    class Program
    {
        // TODO: Replace this string value with the path to actual data file.
        private const string FullPathToDataFile = (@"d:\work diamond\Hackatron-Holiday\Quiz4\quiz-plot\data\Values.Data.txt");

        static void Main(string[] args)
        {

            var read = new ValuesReader();
            var data = read.ReadValuesFromDataFile(FullPathToDataFile);
          
            Console.WriteLine("DOT Plot");

            var average = FindMean(data);

            for (int i = 10; i >= 0; i--)
            {
                if (i >= 0 && i < 10)
                {
                    Console.Write(" ");
                }
                Console.Write(i + " |");
                for (int j = 0; j < data.Length; j++)
                {
                    if (i == data[j])
                    {
                        Console.Write('*');
                    }

                    else if (i == average)
                    {
                        Console.Write('-');
                    }

                    else
                    {
                        Console.Write(" ");
                    }

                    // Console.Write(j);

                }
                Console.WriteLine();
            }

            Console.WriteLine(new String('=', data.Length));
            Console.WriteLine("average is " + average);
            return;
            // TODO: Implement quiz here
        }
        static int FindMean(int[] data)
        {
            var result = data.Average();

            return (int)result;

        }
    }
}
