namespace Design.Cohesion.TemporalCohiseion;

/* 
    Description: 
    this is 5th File.
    It is recommended to check the 4th file (ProcedualCohesion.cs) before reading this file 
*/

public class OrderService
{
    private void ValidateOrder()
    {
        // Todo : Implement order validation logic here 
    }
 
    private void CalculateTax()
    {
        // Todo : Implement tax calculation logic here 
    }
 
    private void GenerateInvoice()
    {
        // Todo : Implement invoice generation logic here 
    }
 
    private void UpdateInventory()
    {
        // Todo : Implement inventory update logic here 
    }
 
    private void SendNotification()
    {
        // Todo : Implement order confirmation logic here 
    }

    public void ProccessOrder()
    {
        ValidateOrder();     
        CalculateTax();      
        GenerateInvoice();   
        UpdateInventory();   
        SendNotification();  
    }
}

public class OrderController(OrderService orderService)
{
    private readonly OrderService _orderService = orderService; 

    public void PostAction()
    {
        _orderService.ProccessOrder();        
    }
}

/*
    Description: 
    In this example, the OrderService class demonstrates temporal cohesion by grouping methods related to order processing together.
*/