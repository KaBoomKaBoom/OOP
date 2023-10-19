using Lab2;

//info allfiles
PrintInfoAllFiles printAllFilesInfo = new PrintInfoAllFiles();
printAllFilesInfo.PrintInfoFiles();

//info image file.png
PrintInfoImageFiles printInfoImageFiles = new PrintInfoImageFiles();
printInfoImageFiles.PrintInfoSpecificFile("test.png");
printInfoImageFiles.PrintImageSize("test.png");