using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Укажите путь к папке: ");
            string path = Console.ReadLine();

            var size = FolderSize.GetDirSize(path);
            Console.WriteLine($"Размер папки: {size} байт.");

            Console.ReadKey();
        }
    }
}
