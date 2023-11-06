using System;
using System.Text.RegularExpressions;

namespace Lab2
{
	public class InfoProgramFiles : InfoAllFiles
	{
        private int lines = 0, classes = 0, methods = 0;
        public void GetCountLines(string fileName) 
        {
            lines = File.ReadLines(Path.Combine(filePath, fileName)).Count();
        }
        public void GetCountClasses(string fileName)
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
        public void GetCountMethodsJava(string fileName)
        {
            string code = File.ReadAllText(Path.Combine(filePath, fileName));
            string pattern = @"(\bpublic|\bprivate|\bprotected|\binternal)?\s+\w+\s+\w+\s*\([^)]*\)\s*{";

            MatchCollection matches = Regex.Matches(code, pattern);
            methods = matches.Count();

        }

        public void GetCountMethodsPython(string fileName)
        {
            string code = File.ReadAllText(Path.Combine(filePath, fileName));
            string pattern = @"(\bdef\s+\w+\s*\([^)]*\):)";
            MatchCollection matches = Regex.Matches(code, pattern);
            methods = matches.Count();

        }
        public void PrintProgramFileInfo(string fileName)
        {
            PrintInfoSpecificFile(Path.Combine(filePath, fileName));
            Console.WriteLine($"Number of lines: {lines}");
            Console.WriteLine($"Number of classes: {classes}");
            Console.WriteLine($"Number of methods: {methods}");
        }
    }
}
