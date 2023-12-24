namespace Design.Cohesion.ProceduralCohesion;

/// <summary>
/// Procedural Cohesion: This type of cohesion occurs when elements are grouped together in a module based on their sequence of execution, 
/// such as a module that performs a set of related procedures in a specific order. Steps towards a common goal.
/// This class demonstrate Procedural Cohesion and the goal is to purchase some items.
/// </summary>
public class ProceduralCohesion
{
    public void ProcessPurchase(Purchase purchase)
    {
        decimal totalCost = CalculateTotalCost(purchase);
        if (ValidatePayment(totalCost))
        {
            PlaceOrder(purchase);
            SendConfirmationEmail(purchase);
        }
    }

    private decimal CalculateTotalCost(Purchase purchase)
    {
        decimal totalCost = purchase.Price * purchase.Quantity;
        totalCost -= totalCost * purchase.Discount;
        return totalCost;
    }

    private bool ValidatePayment(decimal totalCost)
    {
        // Check if payment is valid
        return true;
    }

    private void PlaceOrder(Purchase purchase)
    {
        // Place the order and update inventory
    }

    private void SendConfirmationEmail(Purchase purchase)
    {
        // Send confirmation email to customer
    }
}

public class Purchase
{
    public int Price { get; set; }
    public int Quantity { get; set; }
    public decimal Discount { get; set; }
}