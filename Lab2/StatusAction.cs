using System;
using System.IO;

namespace Lab2
{
	public class StatusAction
	{
		private string filePath = @"TestOOP\";
		public void PrintStatus(DateTime snapshotTime) 
		{
			string[] files = Directory.GetFiles(filePath);
			foreach (var item in files)
			{
				FileInfo fileInfo = new FileInfo(item);
				if (fileInfo.LastWriteTime > snapshotTime )
				{
					Console.WriteLine(fileInfo.Name + " - Changed");
				}
				else
				{
					Console.WriteLine(fileInfo.Name + " - Not Changed");
				}
			}
		}
	}
}
