using System.Collections.Generic;
using System.IO;

namespace DotPlot
{
    public class ValuesReader
    {
        public int[] ReadValuesFromDataFile(string fullPathToFile)
        {
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
}