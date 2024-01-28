using System;
using System.IO;

class Program
{
    static void Main()
    {
        const string FileInput = "Introduce el nombre del archivo (asegúrate de que tenga la extensión .txt):";
        const string WrongExtension = "El archivo debe tener la extensión .txt. Vuelve a intentarlo:";
        const string AddContent = "Introduce el texto a añadir al archivo:";
        const string Successful = "Operación completada con éxito.";
        const string Options = "Que quieres hacer | 1 - Leer / 2 - Escribir |";
        const string WrongChoice = "Opción no válida";

        int choice = 0;
        try
        {
            Console.WriteLine(FileInput);
            string fileName = Console.ReadLine();

            while (!fileName.EndsWith(".txt"))
            {
                Console.WriteLine(WrongExtension);
                fileName = Console.ReadLine();
            }

            Console.WriteLine(Options);
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    ReadFile(fileName);
                    break;
                case 2:
                    Console.WriteLine(AddContent);
                    string content = Console.ReadLine();
                    WriteFile(fileName, content);
                    Console.WriteLine(Successful);
                    break;
                default:
                    Console.WriteLine(WrongChoice);
                    choice = Convert.ToInt32(Console.ReadLine());
                    break;
            }

        }
        catch (Exception ex)
        {
            Console.WriteLine($"Se produjo un error: {ex.Message}");
        }
    }

    static void ReadFile(string fileName)
    {
        const string ShowContent = "Contenido del archivo {0}:\n{1}";
        const string NotExists = "El archivo {0} no existe.";
        if (File.Exists(fileName))
        {
            using (StreamReader sr = new StreamReader(fileName))
            {
                string content = sr.ReadToEnd();
                Console.WriteLine(ShowContent, fileName, content);
            }
        }
        else
        {
            Console.WriteLine(NotExists, fileName);
        }
    }

    static void WriteFile(string fileName, string content)
    {
        using (StreamWriter sw = new StreamWriter(fileName, true))
        {
            sw.WriteLine(content);
        }
    }
}
