using System;
using System.IO;

namespace FileHandling
{
    public class Program
    {
        public static void Main()
        {
            FileHandling("file.txt");
        }

        public static void FileHandling(string file)
        {
            const string EmptyFile = "El archivo está vacío.";
            string path = Path.GetFullPath(@"..\..\..\files\" + file);
            using StreamReader sr = File.OpenText(path);

            // Leer solo la primera línea
            string firstLine = sr.ReadLine();

            if (firstLine != null)
            {
                Console.WriteLine(firstLine);
            }
            else
            {
                Console.WriteLine(EmptyFile);
            }
        }
    }
}
