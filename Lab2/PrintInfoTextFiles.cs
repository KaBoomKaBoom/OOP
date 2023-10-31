using System;
namespace Lab2
{
	public class PrintInfoTextFiles : PrintInfoAllFiles
	{
		
		private int lines = 0, words=0, characters=0;
        
        public void LinesCount(string fileName) 
		{
			lines= File.ReadLines(Path.Combine(filePath, fileName)).Count();
        }
		public void WordCount(string fileName)
		{
            string[] lines = File.ReadAllLines(Path.Combine(filePath, fileName));
            words = lines.SelectMany(line => line.Split(new[] { ' ','.','?','!','/' }, StringSplitOptions.RemoveEmptyEntries)).Count();

        }
		public void CharactersCount(string fileName)
		{
            string[] lines = File.ReadAllLines(Path.Combine(filePath, fileName));
            characters = lines.Sum(line => line.Length);
        }
        public void PrintFileInfo(string fileName) 
		{
            PrintInfoSpecificFile(Path.Combine(filePath, fileName));
            Console.WriteLine($"Number of lines: {lines}");
			Console.WriteLine($"Number of words: {words}");
			Console.WriteLine($"Number of characters: {characters}");
		}
	}
}
