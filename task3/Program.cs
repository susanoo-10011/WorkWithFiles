using System;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Укажите путь к папке: ");
            string path = Console.ReadLine();

            var initialNumberFiles = DataAboutFiles.CountFilesInFolder(path);
            Console.WriteLine($"Общее количество файлов: {initialNumberFiles}");
            var initialSize = DataAboutFiles.GetDirSize(path);
            Console.WriteLine($"Исходный размер папки: {initialSize} байт.");

            ClearFolders.DeleteFolder(path);
            Console.WriteLine("\nПапка очищена!\n");

            var currentNumberFiles = DataAboutFiles.CountFilesInFolder(path);
            Console.WriteLine($"Текущее количество количество файлов: {currentNumberFiles}");
            var differenceFiles = initialNumberFiles - currentNumberFiles;
            Console.WriteLine($"Файлов удалено: {differenceFiles}");
            var currentSize = DataAboutFiles.GetDirSize(path);
            Console.WriteLine($"Текущий размер папки: {currentSize} байт.");
            var differenceSize = initialSize - currentSize;
            Console.WriteLine($"Освобождено: {differenceSize}");

            Console.ReadKey();
        }
    }
}
