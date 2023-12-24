namespace Design.Cohesion;

public class FunctionalCohesion
{

}

public class DifferentTypeOfNumbers
{
    public List<int> GetOddNumbers(List<int> numbers)
    {
        List<int> oddNumbers = [];

        foreach (int number in numbers)
        {
            if (number % 2 != 0)
            {
                oddNumbers.Add(number);
            }
        }

        return oddNumbers;
    }

    public List<int> GetEvenNumbers(List<int> numbers)
    {
        List<int> evenNumbers = [];

        foreach (int number in numbers)
        {
            if (number % 2 == 0)
            {
                evenNumbers.Add(number);
            }
        }

        return evenNumbers;
    }
}
