class NameGenerator
{
    public string Generate(string name, string family, int type)
    {
        string result = string.Empty;

        switch (type)
        {
            case 1:
                result = name + " " + family;
                break;
            case 2:
                result = name;
                break;
        }

        return result;
    }
}

class ShowName
{
    public void Show()
    {
        NameGenerator generator = new NameGenerator();

        var result_1 = generator.Generate("amir", "fazlali", 1);
        var result_2 = generator.Generate("amir", "fazlali", 2);

        // Use result_1 and result_2
    }
}
