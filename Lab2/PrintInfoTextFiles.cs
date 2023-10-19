using System;
namespace Lab2
{
	public class PrintInfoTextFiles : PrintInfoAllFiles
	{
		
		public int lines = 0, words=0, characters=0;
        
        public void LinesCount(string fileName) 
		{
			lines= File.ReadLines(Path.Combine(filePath, fileName)).Count();
        }
		public void PrintFileInfo() 
		{
			Console.WriteLine($"Number of lines: {lines}");
		}
	}
}
