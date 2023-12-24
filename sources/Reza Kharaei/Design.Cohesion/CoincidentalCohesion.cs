
namespace Design.Cohesion.CoincidentalCohesion;

/* 
    Description: 
    this is 7th File.
    It is recommended to check the 6th file (LogincalCohesion.cs) before reading this file 
*/

public class SampleClass
{
    public int CalculateSumValue(int x, int y) => x + y;

    public int GetLength(string message) => message.Length;

    public void Print(string text) => Console.WriteLine(text);
}

/*
    Description:
    They are grouped but not in line with a common goal!
*/