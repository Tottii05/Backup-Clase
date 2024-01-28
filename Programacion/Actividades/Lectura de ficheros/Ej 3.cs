using System;
using System.IO;

namespace FileHandling
{
    public class Program
    {
        public static void Main()
        {
            const string FileInput = "Introduce el nombre del fichero:";
            const string FileLines = "El fichero {0} tiene {1} líneas";

            try
            {
                Console.WriteLine(FileInput);
                string fileName = Console.ReadLine();

                FileHandling(fileName, FileLines);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Error: El fichero no fue encontrado.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Se produjo un error: {ex.Message}");
            }
        }

        public static void FileHandling(string fileName, string fileLines)
        {
            string path = Path.GetFullPath(@"..\..\..\files\" + fileName);
            int lines = 0;

            using (StreamReader sr = File.OpenText(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    lines++;
                }
            }

            Console.WriteLine(fileLines, fileName, lines);
        }
    }
}
