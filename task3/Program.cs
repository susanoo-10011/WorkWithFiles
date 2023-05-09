using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Укажите путь к папке: ");
            string path = Console.ReadLine();

            var count = DataAboutFiles.CountFilesInFolder(path);
            Console.WriteLine($"Общее количество файлов: {count}");

            var size = DataAboutFiles.GetDirSize(path);
            Console.WriteLine($"Исходный размер папки: {size} байт.");



            Console.ReadKey();
        }
    }
}
