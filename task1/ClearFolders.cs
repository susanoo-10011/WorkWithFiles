using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal static class ClearFolders
    {
        public static void GetData()
        {
            Console.Write("Укажите путь до папки или файла: ");
            var userInput = Console.ReadLine();

            try
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(userInput);
                TimeSpan timeSpan = TimeSpan.FromMinutes(2);

                if (!directoryInfo.Exists )
                {
                    Console.WriteLine("Папка не существует!");
                    return;
                }

                foreach (FileInfo file in directoryInfo.GetFiles())
                {
                    if (file.LastAccessTime + timeSpan < DateTime.Now)
                    {
                        file.Delete();
                        Console.WriteLine($"Удален файл: {file.FullName}");
                    }
                }

                foreach (DirectoryInfo directory in directoryInfo.GetDirectories())
                {
                    if (directory.LastAccessTime + timeSpan < DateTime.Now)
                    {
                        directory.Delete(true);
                        Console.WriteLine($"Удалена папка: {directory.FullName}");
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при очистке папки: {ex.Message}");
            }
        }
    }
}
