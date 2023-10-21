using System;
using System.IO;

namespace Lab2
{
	public class StatusAction
	{
		private string filePath = @"TestOOP\";
		public void PrintStatus(DateTime snapshotTime, List<string> previousFiles) 
		{
			string[] files = Directory.GetFiles(filePath);
			List<string> currentFiles = files.ToList();
			foreach (var item in currentFiles)
			{
				FileInfo fileInfo = new FileInfo(item);
				Console.WriteLine(fileInfo.Name);
				if (fileInfo.LastWriteTime > snapshotTime && previousFiles.Contains(fileInfo.Name))
				{
					Console.WriteLine(fileInfo.Name + " - Changed");
				}
				else if(!previousFiles.Contains(fileInfo.Name))
				{
					Console.WriteLine(fileInfo.Name + " - Added");
				}
				else
				{
					Console.WriteLine(fileInfo.Name + " - Not Changed");
				}
			}
			foreach (var item in previousFiles) 
			{
				FileInfo fileInfo = new FileInfo(item);
				if (!currentFiles.Contains(fileInfo.Name))
				{
					Console.WriteLine(fileInfo.Name + " - Deleted");
				}
				
			}
		}
	}
}
