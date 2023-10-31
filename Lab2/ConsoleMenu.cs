using Lab2;
using System;

namespace Lab2
{
	public class ConsoleMenu
	{
		public void ConsoleOperations()
		{
			string option = "";
			DateTime snapshotTime = DateTime.Now;
			CommitAction commitAction = new CommitAction();
			SnapshotStorageFileManager snapshotStorage = new SnapshotStorageFileManager();
			PrintInfoAllFiles printAllFilesInfo = new PrintInfoAllFiles();
			PrintInfoImageFiles printInfoImageFiles = new PrintInfoImageFiles();
			PrintInfoTextFiles printInfoTextFiles = new PrintInfoTextFiles();
			PrintInfoProgramFiles printInfoProgramFiles = new PrintInfoProgramFiles();
			StatusAction statusAction = new StatusAction();
			SnapshotStorageFileManager snapshotFileManager = new SnapshotStorageFileManager();

			Console.WriteLine("Available options: ");
			Console.WriteLine("1. commit");
			Console.WriteLine("2. info <filename> (allfiles, image, text, program)");
			Console.WriteLine("3. status");
			Console.WriteLine("4. q - quit");
			while (option != "q")
			{
				
				Console.Write("\n>>> ");
				option = Console.ReadLine();
				string[] splitOption = option.Split(' ');
				switch (splitOption[0])
				{
					case "commit":
						snapshotTime = commitAction.UpdateSnaphotTime();
						snapshotStorage.StoreSnapshot(snapshotTime);
						break;
					case "info":
						string[] getExtension = splitOption[1].Split('.');
						switch (getExtension.Length)
						{
							case 1:
								//info allfiles
								printAllFilesInfo.PrintInfoFiles();
								break;
							case 2:
								switch (getExtension[1])
								{
									case "png":
										//info image file.png  +++
										printInfoImageFiles.PrintImageSize(splitOption[1]);
										break;
									case "txt":
										//info text file.txt
										printInfoTextFiles.LinesCount(splitOption[1]);
										printInfoTextFiles.WordCount(splitOption[1]);
										printInfoTextFiles.CharactersCount(splitOption[1]);
										printInfoTextFiles.PrintFileInfo(splitOption[1]);
										break;

									//info programFiles
									case "cs":
										printInfoProgramFiles.CountLines(splitOption[1]);
										printInfoProgramFiles.CountClasses(splitOption[1]);
										printInfoProgramFiles.CountMethodsJava(splitOption[1]);
										printInfoProgramFiles.PrintProgramFileInfo(splitOption[1]);
										break;
									case "py":
										printInfoProgramFiles.CountLines(splitOption[1]);
										printInfoProgramFiles.CountClasses(splitOption[1]);
										printInfoProgramFiles.CountMethodsPython(splitOption[1]);
										printInfoProgramFiles.PrintProgramFileInfo(splitOption[1]);
										break;


								}
								break;
						}
						break;
					case "status":
						snapshotFileManager.ExtractLastSnapshot(snapshotTime);
						var previousFiles = new List<string>();
						snapshotFileManager.ExtractSavedFiles(previousFiles);
						statusAction.PrintStatus(snapshotTime, previousFiles);
						break;
					case "q":
						break;
					default:
						Console.WriteLine("Wrong operation!");
						break;
				}
			}
        }
    }
}

