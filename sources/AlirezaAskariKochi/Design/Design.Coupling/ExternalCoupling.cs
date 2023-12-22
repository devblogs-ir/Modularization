using System;
using System.IO;
using static Design.Coupling.ExternalCoupling;

namespace Design.Coupling
{
    public class ExternalCoupling
    {
        public class FileProcessor
        {
            private string _filePath;

            public FileProcessor(string filePath)
            {
                _filePath = filePath;
            }

            public void WriteToFile(string content)
            {
                File.WriteAllText(_filePath, content);
            }

            public string ReadFromFile()
            {
                return File.ReadAllText(_filePath);
            }
        }
    }
    class Program
    {
        static void Main()
        {
            string filePath = @"C:\path\file.txt";
            FileProcessor fileProcessor = new FileProcessor(filePath);

            fileProcessor.WriteToFile("this is External Coupling test.");

            string content = fileProcessor.ReadFromFile();
            Console.WriteLine(content);
        }
    }
}
