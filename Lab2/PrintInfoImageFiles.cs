using System;
using System.Drawing;

namespace Lab2
{
    public class PrintInfoImageFiles : PrintInfoAllFiles
    {
        public void PrintImageSize(string fileName)
        {
            Image newImage = Image.FromFile(Path.Combine(filePath, fileName));
            Console.WriteLine($"Image size: {newImage.Width}x{newImage.Height}");

        }
    }
}