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

            bool insideClass = false;

            foreach (string line in lines)
            {
                // Check if the line contains the class keyword
                if (Regex.IsMatch(line, @"\bclass\b"))
                {
                    if (!insideClass)
                    {
                        classes++;
                        insideClass = true;
                    }
                }
                // Check if the line contains the closing brace of a class
                else if (insideClass && line.Contains("}"))
                {
                    insideClass = false;
                }
            }
        }
        public void CountMethods(string fileName)
        {
            string[] lines = File.ReadAllLines(Path.Combine(filePath, fileName));

            // Regular expression to match common C# method signatures
            Regex methodSignatureRegex = new Regex(@"\b(?:public|private|protected|internal)?\s+\w+\s+\w+\s*\(.+\)");

            foreach (string line in lines)
            {
                if (methodSignatureRegex.IsMatch(line))
                {
                    methods++;
                }
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
