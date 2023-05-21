using System;
using System.IO;

class Program
{
    static int CountFilesInDirectory(string directoryPath)
    {
        int fileCount = 0;

        foreach (string file in Directory.EnumerateFiles(directoryPath, "*", SearchOption.AllDirectories))
        {
            fileCount++;
        }

        return fileCount;
    }

    static void Main(string[] args)
    {
        string directoryPath = "C:\\Program Files (x86)\\Microsoft"; 

        int fileCount = CountFilesInDirectory(directoryPath);
        Console.WriteLine("Количество Файлов: " + fileCount);
    }
}
