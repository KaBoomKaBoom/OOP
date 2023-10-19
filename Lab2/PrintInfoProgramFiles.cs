using System;

namespace Lab2
{
	public class PrintInfoProgramFiles : PrintInfoAllFiles
	{
        private int lines = 0, classes = 0, methods = 0;
        public void CountLines(string fileName) 
        {
            lines = File.ReadLines(Path.Combine(filePath, fileName)).Count();
        }
        public void PrintProgramFileInfo()
        {
            Console.WriteLine($"Number of lines: {lines}");
        }
    }
}
