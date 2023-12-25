
namespace Coupling.ExternalCoupling
{
    public class FileReaderModule
    {
        private readonly string _filePath;

        public FileReaderModule(string filePath)
        {
            this._filePath = filePath;
        }

        public void ReadFile()
        {
            try
            {
                if (!File.Exists(_filePath))
                {
                    Console.WriteLine($"File not found at path: {_filePath}");
                    return;
                }

                string fileContents = File.ReadAllText(_filePath);

                Console.WriteLine($"File Contents: {fileContents}");


            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error reading the file: {ex.Message}");
            }
        }

    }
}
