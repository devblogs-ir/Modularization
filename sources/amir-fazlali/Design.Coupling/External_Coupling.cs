class FileReader
{
    public int CountLines(string fileName)
    {
        int count = 0;

        try
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                while (reader.ReadLine() != null)
                {
                    count++;
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        return count;
    }
}

class FileWriter
{
    public void Write(string fileName, string message)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine(message);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}


// Example :
// FileWriter writer = new ();
// FileReader reader = new ();
// writer.Write("amir.txt", "hello amir");
// var res = reader.CountLines("amir.txt");
// Console.WriteLine(res);
