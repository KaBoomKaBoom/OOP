using Lab2;

string option = "";
DateTime snapshotTime = DateTime.Now;

Console.WriteLine("Available options: ");
Console.WriteLine("1. commit");
Console.WriteLine("2. info <filename> (allfiles, image, text, program)");
Console.WriteLine("3. status");
while (option != "q")
{
    Console.Write(">>> ");
    option = Console.ReadLine();
    string[] splitOption = option.Split(' ');
    switch (splitOption[0]) 
    {
        case "commit":
            CommitAction commitAction = new CommitAction();
            SnapshotStorageFileManager snapshotStorage = new SnapshotStorageFileManager();
            commitAction.UpdateSnaphotTime();
            snapshotStorage.StoreSnapshot(commitAction.snapshotTime, commitAction.fileSnapshots);
            break;
        case "info":
            string[] getExtension = splitOption[1].Split('.');
            switch (getExtension.Length) 
            {
                case 1:
                    //info allfiles
                    PrintInfoAllFiles printAllFilesInfo = new PrintInfoAllFiles();
                    printAllFilesInfo.PrintInfoFiles();
                    break;
                case 2:
                    switch (getExtension[1])
                    {
                        case "png":
                            //info image file.png  +++
                            PrintInfoImageFiles printInfoImageFiles = new PrintInfoImageFiles();
                            printInfoImageFiles.PrintInfoSpecificFile(splitOption[1]);
                            printInfoImageFiles.PrintImageSize(splitOption[1]);
                        break;
                        case "txt":
                            //info text file.txt
                            PrintInfoTextFiles printInfoTextFiles = new PrintInfoTextFiles();
                            printInfoTextFiles.PrintInfoSpecificFile(splitOption[1]);
                            printInfoTextFiles.LinesCount(splitOption[1]);
                            printInfoTextFiles.WordCount(splitOption[1]);
                            printInfoTextFiles.CharactersCount(splitOption[1]);
                            printInfoTextFiles.PrintFileInfo();
                            break;
                        default:
                            //info programFiles
                            PrintInfoProgramFiles printInfoProgramFiles = new PrintInfoProgramFiles();
                            printInfoProgramFiles.PrintInfoSpecificFile(splitOption[1]);
                            printInfoProgramFiles.CountLines(splitOption[1]);
                            printInfoProgramFiles.CountClasses(splitOption[1]);
                            printInfoProgramFiles.CountMethods(splitOption[1]);
                            printInfoProgramFiles.PrintProgramFileInfo();
                            break;
                    }
                    break;
            }
            break;
        case "status":
            StatusAction statusAction= new StatusAction();
			SnapshotStorageFileManager snapshot = new SnapshotStorageFileManager();
			snapshot.ExtractrLastSnapshot(snapshotTime);
			var previousFiles = new List<string>();
			snapshot.ExtractSavedFiles(previousFiles);
            Console.WriteLine(previousFiles.Count);
            statusAction.PrintStatus(snapshotTime,previousFiles);
            break;
        case "q":
            break;
        default :
            Console.WriteLine("Wrong operation!");
            break;
    }
}