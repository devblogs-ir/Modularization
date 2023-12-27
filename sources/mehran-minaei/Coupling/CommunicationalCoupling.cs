namespace Coupling;
public readonly record struct OrderModel (int Id,string Date,decimal  Price);
class OrderProcessor
{
    private InventoryManager inventoryManager;


    public OrderProcessor()
    {
        inventoryManager = new InventoryManager();
    }

    public void ProcessOrder(OrderModel order)
    {
        // Code to process the order

        inventoryManager.UpdateInventory(order);
    }
}

class InventoryManager
{
    private NotificationService notificationService;

    public InventoryManager()
    {
        notificationService = new NotificationService();
    }

    public void UpdateInventory(OrderModel order)
    {
        // Code to update the inventory based on the order

        notificationService.SendNotification("Inventory updated");
    }
}

class NotificationService
{
    public void SendNotification(string message)
    {
        // Code to send a notification
    }
}


// in this example classes depended together, 