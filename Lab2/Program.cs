using Lab2;

//info allfiles
PrintInfoAllFiles printAllFilesInfo = new PrintInfoAllFiles();
printAllFilesInfo.PrintInfoFiles();

//info image file.png
PrintInfoImageFiles printInfoImageFiles = new PrintInfoImageFiles();
printInfoImageFiles.PrintInfoSpecificFile("test.png");
printInfoImageFiles.PrintImageSize("test.png");

//info text file.txt
PrintInfoTextFiles printInfoTextFiles = new PrintInfoTextFiles();
printInfoTextFiles.LinesCount("BazeDeDate.txt");
printInfoTextFiles.WordCount("BazeDeDate.txt");
printInfoTextFiles.CharactersCount("BazeDeDate.txt");
printInfoTextFiles.PrintFileInfo();

//info programFiles
PrintInfoProgramFiles printInfoProgramFiles = new PrintInfoProgramFiles();
printInfoProgramFiles.CountLines("FileManager.cs");
printInfoProgramFiles.PrintProgramFileInfo();