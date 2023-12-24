namespace Design.Cohesion.LogincalCohesion;

/* 
    Description: 
    this is 6th File.
    It is recommended to check the 5th file (TemporalCohiseion.cs) before reading this file 
*/


public record GenderPercentage(int PercentageOfFemale, int PercentageOfMale);

public class UserService
{
    private int GetFemaleUserCount()
    {
        // Todo: Returns the number of female users from the total number of users
        return 10; 
    }

    private int GetMaleUserCount()
    {
        // Todo: Returns the number of man users from the total number of users
        return 12;
    }

    public GenderPercentage GetGenderPercentage()
    {
        var MaleCount = GetMaleUserCount();
        var FemaleCount = GetFemaleUserCount();
        var AllCount = MaleCount + FemaleCount;
        var PercentageOfMale = (MaleCount * 100) / AllCount;
        var PercentageOfFemale = (FemaleCount * 100) / AllCount;
        return new GenderPercentage(PercentageOfFemale, PercentageOfMale);
    }
}


/*
    Description:
    in the GetGenderPercentage method, GetMaleUserCount and GetFemaleUserCount methods are grouped 
    because they are logically categorized to do the same thing, even if they are different by nature 
*/