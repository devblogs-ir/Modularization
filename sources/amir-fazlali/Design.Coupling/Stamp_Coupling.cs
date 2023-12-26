struct Experts
{
    public string Name;
    public int Age;
    public string Skill;
}

class CSharpSkillFinder
{
    public Experts[] Find(Experts[] experts)
    {
        Experts[] cSharpExperts = new Experts[] {};

        int j = 0;

        for (int i = 0; i < experts.Length; i++)
        {
            if (experts[i].Skill == "C#")
            {
                cSharpExperts[j] = experts[i];
                j++;
            }
        }

        return cSharpExperts;
    }
}

class ExpertsAgeAverage
{
    public double Average(Experts[] experts)
    {
        int sum = 0;

        foreach (Experts expert in experts)
        {
            sum += expert.Age;
        }

        return sum / experts.Length;
    }
}
