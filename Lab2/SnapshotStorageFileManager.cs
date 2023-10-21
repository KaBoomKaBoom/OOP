using System;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;

namespace Lab2
{
	public class SnapshotStorageFileManager
	{
		string fileName = "Snapshots.txt";
		protected string filePath = @"TestOOP\";

		public void StoreSnapshot(DateTime snapshotTime, Dictionary<string, FileSnapshot> fileSnapshots) 
		{
			string FMT = "O";
			string contentToSave = snapshotTime.ToString(FMT)+"\n";
			string[] files = Directory.GetFiles(filePath);
			foreach (var item in files) 
			{
				FileInfo fileInfo = new FileInfo(item);
				contentToSave += fileInfo.Name + "\n";	
			}
			File.WriteAllText(fileName, contentToSave);
		}
		public void ExtractrLastSnapshot(DateTime snapshotTime)
		{
			string FMT = "O";
			string[] contentToExtract = File.ReadAllLines(fileName);
			snapshotTime = DateTime.ParseExact(contentToExtract[0], FMT, CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind);
			Console.WriteLine(snapshotTime);
		}
		public void ExtractSavedFiles(List<string> savedFiles) 
		{
			string[] contentToExtract = File.ReadAllLines(fileName);
			for (int i = 1; i < contentToExtract.Length; i++)
			{
				savedFiles.Add(contentToExtract[i]);
			}
		}
	}
}