using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Lab2
{
	public class SnapshotStorageFileManager
	{
		string fileName = "Snapshots.txt";
		protected static string filePath = @"C:\\Users\Victor\source\repos\OOP\Lab2\TestOOP\";
		
		
		public void StoreSnapshot(Dictionary<string, FileSnapshot> fileSnapshots) 
		{
			string contentToSave = "";
			foreach (var pair in fileSnapshots) 
			{
				contentToSave=pair.Key+"     ["+pair.Value+"]\n";
			}
			File.WriteAllText(fileName, contentToSave);
		}
		
	}
}