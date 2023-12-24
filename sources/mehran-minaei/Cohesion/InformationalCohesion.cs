namespace Cohesion;

public class InformationalCohesion
{ 
    public string ProductName { get; set; }
    public decimal Price { get; set; }
   
    
    // Methods related to product information
    public void UpdateProductName(string newName)
    {
        // Code to update the product's name
    }
    
    public void UpdatePrice(int newAge)
    {
        // Code to update the product's age
    }
    

}

class ProductDatabase
{
    private List<InformationalCohesion> products;
    
   
    public void AddProduct(InformationalCohesion product)
    {
       
    }
    
    public void RemoveProduct(InformationalCohesion product)
    {
        
    }
    
    public InformationalCohesion FindProduct(string name)
    {
       
    }
}


// By grouping code elements based on their relationship to a specific information or data structure, you achieve informational cohesion. 