class ScoreCalculation
{
    public float Calculate(int[] scores)
    {
        try
        {
            int sum = 0;

            foreach(int score in scores)
            {
                sum += score;
            }

            return sum / scores.Length;
        }
        catch
        {
            return 0;
        }
    }
}

class ShowSomthing
{
    void Show()
    {
        int[] scores = [1, 5, 7, 8];

        ScoreCalculation calculator = new ScoreCalculation();

        var result = calculator.Calculate(scores);

        // Use "result" desired
    }
}
