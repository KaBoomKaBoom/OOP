using Lab2;

string option = "";
Console.WriteLine("Available options: ");
Console.WriteLine("1. commit");
Console.WriteLine("2. info <filename> (allfiles, image, text, program)");
Console.WriteLine("3. status");
while (option != "q")
{
    option = Console.ReadLine();
    string[] splitOption = option.Split(' ');
    switch (splitOption[0]) 
    {
        case "commit":
            CommitAction commitAction = new CommitAction();
            SnapshotStorageFileManager snapshotStorage = new SnapshotStorageFileManager();
            commitAction.UpdateSnaphotTime();
            snapshotStorage.StoreSnapshot(commitAction.snapshotTime);
            //snapshotStorage.ExtractrLastSnapshot(commitAction.snapshotTime);
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
                            printInfoProgramFiles.CountLines("FileManager.cs");
                            printInfoProgramFiles.CountClasses("FileManager.cs");
                            printInfoProgramFiles.CountMethods("FileManager.cs");
                            printInfoProgramFiles.PrintProgramFileInfo();
                            break;
                    }
                    break;


            }
            break;
    }
}