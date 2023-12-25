namespace Design.Cohesion;

public class Functional
{
    public int Sum(List<int> nums) => nums.Sum();

    public int Average(List<int> nums) => Sum(nums) / nums.Count;
    
  
    
    public int Variance(List<int> nums,int average)
    {
        int result = 0;
        foreach (var x in nums)
        {
            result+= (x - average) ^ 2;
        }

        result = result / (nums.Count - 1);

        return result;

    }
    public double StandardDeviation(List<int> nums)
    {
        int average = Average(nums);
        return Math.Sqrt(Variance(nums,average));
    }
}
