class DataProcessor
{
    public int Sum(int[] array)
    {
        int sum = 0;

        foreach (int num in array)
        {
            sum += num;
        }

        return sum;
    }

    public double Average(int[] array)
    {
        int sum = Sum(array);

        return sum / array.Length;
    }

    public void Print(int[] array)
    {
        foreach (int num in array)
        {
            Console.WriteLine(num);
        }
    }
}

// Example :
// int[] array = new int[] { 1, 2, 3, 4, 5 };
// DataProcessor processor = new DataProcessor();
// processor.Sum(array);
// processor.Average(array);
// processor.Print(array);