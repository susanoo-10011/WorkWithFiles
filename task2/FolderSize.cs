using System;
using System.IO;

namespace task2
{
    internal class FolderSize
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
    }
}
