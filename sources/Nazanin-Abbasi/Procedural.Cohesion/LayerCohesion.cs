namespace Design.Cohesion.LayerCohesion;

/// <summary>
/// Layer (Logical) Cohesion: Layer cohesion occurs when elements in a module are grouped together based on their level of abstraction or responsibility,
/// such as a layer that handles only low-level hardware interactions or a layer that handles only business logic. 
/// All the code for these interactions is then located in the same layer.
/// </summary>
public class DataLayer
{
    public void InsertRecord(string tableName, Dictionary<string, object> record)
    {
        // Insert record logic
    }

    public void UpdateRecord(string tableName, Dictionary<string, object> record, string condition)
    {
        // Update record logic
    }

    public void DeleteRecord(string tableName, string condition)
    {
        // Delete record logic
    }
}

public class BusinessLayer
{
    private DataLayer dataLayer = new();

    public void AddRecord(string tableName, Dictionary<string, object> record)
    {
        // Add record logic
        dataLayer.InsertRecord(tableName, record);
    }

    public void UpdateRecord(string tableName, Dictionary<string, object> record, string condition)
    {
        // Update record logic
        dataLayer.UpdateRecord(tableName, record, condition);
    }

    public void RemoveRecord(string tableName, string condition)
    {
        // Remove record logic
        dataLayer.DeleteRecord(tableName, condition);
    }
}

public class PresentationLayer
{
    private BusinessLayer businessLayer = new();

    public void AddRecord(string tableName, Dictionary<string, object> record)
    {
        // Add record logic
        businessLayer.AddRecord(tableName, record);
    }

    public void UpdateRecord(string tableName, Dictionary<string, object> record, string condition)
    {
        // Update record logic
        businessLayer.UpdateRecord(tableName, record, condition);
    }

    public void RemoveRecord(string tableName, string condition)
    {
        // Remove record logic
        businessLayer.RemoveRecord(tableName, condition);
    }
}

