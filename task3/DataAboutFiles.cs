using System;
using System.IO;

namespace task3
{
    internal static class DataAboutFiles
    {
        public static long GetDirSize(string dirURL)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(dirURL);

            if (dirInfo.Exists)
            {
                long size = 0;

                try
                {
                    foreach (FileInfo file in dirInfo.GetFiles())
                    {
                        size += file.Length;
                    }

                    foreach (DirectoryInfo dir in dirInfo.GetDirectories())
                    {
                        size += GetDirSize(dir.FullName);
                    }
                }
                catch { }

                return size;
            }
            else
            {
                Console.WriteLine("Такого пути не существует!");
                return 0;
            }
        }

        public static int CountFilesInFolder(string folderPath)
        {
            int fileCount = 0;

            try
            {
                fileCount += Directory.GetFiles(folderPath).Length;

                string[] subdirectories = Directory.GetDirectories(folderPath);
                foreach (string subdirectory in subdirectories)
                {
                    fileCount += CountFilesInFolder(subdirectory);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Произошла ошибка: " + e.Message);
            }

            return fileCount;
        }
    }
}
