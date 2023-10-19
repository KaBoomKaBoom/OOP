using System;

public class PrintInfoAllFiles
{
	private string filePath= @"C:\\Users\Andrei\Desktop\TestOOP\";
    
	public void PrintInfo()
	{
        string[] files = Directory.GetFiles(filePath);
        foreach (var item in files)
        {
            FileInfo fileInfo = new FileInfo(item);
            Console.WriteLine("File Name: " + fileInfo.Name);
            Console.WriteLine("Extension: " + fileInfo.Extension);
            Console.WriteLine("Created: " + fileInfo.CreationTime);
            Console.WriteLine("Last Updated: " + fileInfo.LastWriteTime);
        }
    }
}
	