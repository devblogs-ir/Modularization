namespace Design.Cohesion;

public class Temporal
{
    public void SendDiscountCode()
    {
        if (new DateOnly().Day % 3 == 0)
        {
            Console.WriteLine();
        }
    }
}
