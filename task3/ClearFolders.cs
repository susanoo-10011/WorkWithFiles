using System;
using System.IO;

namespace task3
{
    internal static class ClearFolders
    {
        public static void DeleteFolder(string userInput)
        {
            try
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(userInput);

                if (!directoryInfo.Exists)
                {
                    Console.WriteLine("Папка не существует!");
                    return;
                }

                foreach (DirectoryInfo directory in directoryInfo.GetDirectories())
                {
                    directory.Delete(true);
                    Console.WriteLine($"Удалена папка: {directory.FullName}");
                }

                foreach (FileInfo file in directoryInfo.GetFiles())
                {
                    file.Delete();
                    Console.WriteLine($"Удален файл: {file.FullName}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при очистке папки: {ex.Message}");
            }
        }
    }
}
