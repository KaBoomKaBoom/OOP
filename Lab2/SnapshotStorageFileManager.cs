using System;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;

namespace Lab2
{
	public class SnapshotStorageFileManager
	{
		string fileName = "Snapshots.txt";
		
		public void StoreSnapshot(DateTime snapshotTime) 
		{
			string FMT = "O";
			string contentToSave = snapshotTime.ToString(FMT);
			File.WriteAllText(fileName, contentToSave);
		}
		public void ExtractrLastSnapshot(DateTime snapshotTime)
		{
			string FMT = "O";
			string contentToExtract = File.ReadAllText(fileName);
			snapshotTime = DateTime.ParseExact(contentToExtract, FMT, CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind);
			Console.WriteLine(snapshotTime);
		}

	}
}