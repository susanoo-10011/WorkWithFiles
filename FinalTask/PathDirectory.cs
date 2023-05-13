using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace FinalTask
{
    internal class PathDirectory
    {
        public void CreateDirectoryStudents()
        {
            DirectoryInfo dirInfo = new DirectoryInfo(@"C:\Users\Егор\Desktop\Students");
            if (!dirInfo.Exists)
                dirInfo.Create();

            const string pathDirectory = @"C:\Users\Егор\Downloads\Students.dat";
            BinaryFormatter formatter = new BinaryFormatter();

            using (var fs = new FileStream(pathDirectory, FileMode.Open))
            {
                var students = (Student[])formatter.Deserialize(fs);

                foreach (var student in students)
                {
                    string fileGroup = Path.Combine(dirInfo.FullName, student.Group);

                    if (!File.Exists(fileGroup))
                        using (var fileStream = File.Create(fileGroup)) { }

                    using (var fileStream = new FileStream(fileGroup, FileMode.Append))
                    using (var writer = new StreamWriter(fileStream))
                    {
                        writer.Write($"Имя: {student.Name} ");
                        writer.WriteLine($"Дата рождения: {student.DateOfBirth}");
                    }
                }
            }
        }
    }
}

