using System;
using System.Text.RegularExpressions;

namespace Lab2
{
	public class PrintInfoProgramFiles : PrintInfoAllFiles
	{
        private int lines = 0, classes = 0, methods = 0;
        public void CountLines(string fileName) 
        {
            lines = File.ReadLines(Path.Combine(filePath, fileName)).Count();
        }
        public void CountClasses(string fileName)
        {
            string[] lines = File.ReadAllLines(Path.Combine(filePath, fileName));
            foreach (string line in lines)
            {
                // Check if the line contains the class keyword
                if (Regex.IsMatch(line, @"\bclass\b"))
                {
                    classes++;
                }
            }
        }
        public void CountMethods(string fileName)
        {
            string code = File.ReadAllText(Path.Combine(filePath, fileName));
            string pattern = @"(\bpublic|\bprivate|\bprotected|\binternal)?\s+\w+\s+\w+\s*\([^)]*\)\s*{";

            MatchCollection matches = Regex.Matches(code, pattern);
            foreach (Match match in matches)
            {
                methods++;
            }
        }
        public void PrintProgramFileInfo()
        {
            Console.WriteLine($"Number of lines: {lines}");
            Console.WriteLine($"Number of classes: {classes}");
            Console.WriteLine($"Number of methods: {methods}");
        }
    }
}
