using System;
using System.Drawing;

namespace Lab2
{
    public class InfoImageFiles : InfoAllFiles
    {
        public void PrintImageSize(string fileName)
        {
            PrintInfoSpecificFile(Path.Combine(filePath, fileName));
            Image newImage = Image.FromFile(Path.Combine(filePath, fileName));
            Console.WriteLine($"Image size: {newImage.Width}x{newImage.Height}");

        }
    }
}