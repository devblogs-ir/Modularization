using System.Text;

class FileOptions
{
    public FileStream OpenFile(string fileName)
    {
        FileStream fileStream = null;

        if (File.Exists(fileName))
        {
            FileAttributes attributes = File.GetAttributes(fileName);
            if ((attributes & FileAttributes.ReadOnly) != FileAttributes.ReadOnly)
            {
                fileStream = File.Open(fileName, FileMode.Open, FileAccess.ReadWrite);
            }
        }

        return fileStream;
    }

    void Write(string fileName, string message)
    {
        FileStream stream = OpenFile(fileName);

        byte[] bytedata = Encoding.Default.GetBytes(message);

        stream.Write(bytedata, 0, bytedata.Length);

        stream.Close();
    }
}
