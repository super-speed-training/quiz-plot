using System;
using System.Linq;

namespace DotPlot {
    class Program {
        // TODO: Replace this string value with the path to actual data file.
        private const string FullPathToDataFile = @"Values.Data.txt";
        static void Main (string[] args) {
            var ans = new ValuesReader ();
            int[] input = ans.ReadValuesFromDataFile (FullPathToDataFile);
            Console.WriteLine ("DOT Plot");
            foreach (var item in input)
            {
               Console.WriteLine (item); 
            }
            

            // TODO: Implement quiz here
        }
    }
}