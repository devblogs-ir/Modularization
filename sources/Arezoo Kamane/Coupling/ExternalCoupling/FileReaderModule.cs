
namespace Coupling.ExternalCoupling
{
    public class FileReaderModule
    {
        private readonly string filePath;

        public FileReaderModule(string filePath)
        {
            this.filePath = filePath;
        }

        public void ReadFile()
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    Console.WriteLine($"File not found at path: {filePath}");
                    return;
                }

                string fileContents = File.ReadAllText(filePath);

                Console.WriteLine($"File Contents: {fileContents}");


            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error reading the file: {ex.Message}");
            }
        }

    }
}
