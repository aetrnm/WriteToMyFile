using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace FileReadWrite
{
    class Program
    {
        static string path = "C:\\Users\\banan\\Desktop\\myfile.txt";
        static void Main()
        {
            var fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            var sr = new StreamReader(fs, Encoding.Default);

            string line = String.Empty;

            string[] lines = { "First line", "Second line", "Third line" };
            System.IO.File.WriteAllLines(path, lines);

            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }
}