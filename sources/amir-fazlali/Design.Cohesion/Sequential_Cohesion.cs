class StringProcessor
{
    public string Process(string input)
    {
        string output = "";

        output = input.ToUpper();

        output = Reverse(output);

        output = output + output;

        return output;
    }

    private string Reverse(string s)
    {
        char[] array = s.ToCharArray();

        Array.Reverse(array);

        return new string(array);
    }
}

//StringProcessor processor = new StringProcessor();
//processor.Process("hello"); 
