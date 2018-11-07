using System;
using System.Linq;

namespace DotPlot
{
    class Program
    {
        // TODO: Replace this string value with the path to actual data file.
        private const string FullPathToDataFile = @"Values.Data.txt";


        static void Main(string[] args)
        {
            Console.WriteLine("DOT Plot");
            // var values = new ValuesReader();
            // var keepValue = values.ReadValuesFromDataFile(FullPathToDataFile);

            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine(i + "  |");
            }
            Console.WriteLine("==============================================");
            // TODO: Implement quiz here
        }
    }
}
// for (int i = 0; i<11; i++)
//     {
//         for()
//         {
//             Console.WriteLine(i + "  |");
//         }
        
//     }