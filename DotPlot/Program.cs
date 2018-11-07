using System;
using System.Linq;
using System.IO;


namespace DotPlot
{
    class Program
    {
        // TODO: Replace this string value with the path to actual data file.
        private const string FullPathToDataFile =(@"d:\work diamond\Hackatron-Holiday\Quiz4\quiz-plot\data\Values.Data.txt");

        static void Main(string[] args)
        {

            Console.WriteLine("DOT Plot");
            Console.WriteLine(File.ReadLines(FullPathToDataFile));
            
            
            
            // TODO: Implement quiz here
        }
    }
}
