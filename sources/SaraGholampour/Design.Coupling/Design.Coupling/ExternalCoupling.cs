namespace Design.Coupling;

public class ExternalCoupling
{
    public static void Main(string[] args)
    {
        User sara = new("sara", 22, new DateOnly(), null);
        sara.HangleImageUrl();
    }
}
