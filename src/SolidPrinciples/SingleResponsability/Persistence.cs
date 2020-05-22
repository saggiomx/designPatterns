using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SolidPrinciples.SingleResponsability
{
    public class Persistence
    {
        public void SaveToFile(Journal journal, string fileName, bool overwrite = false)
        {
            if (overwrite || !File.Exists(fileName))
                File.WriteAllText(fileName, journal.ToString());
        }

        public static Journal Load(string fileName)
        {
            return new Journal();
        }

        public static Journal Load(Uri uri)
        {
            return new Journal();
        }
    }
}
