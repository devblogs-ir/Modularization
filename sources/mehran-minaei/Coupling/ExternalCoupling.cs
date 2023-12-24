namespace Coupling.ExternalCoupling;

// Component A
class ComponentA
{
    public void ReadDataFromCSV(string filePath)
    {
        // Read data from a CSV file
        // Process the data
    }
}

// Component B
class ComponentB
{
    public void ReadDataFromXML(string filePath)
    {
        // Read data from an XML file
        // Process the data
    }
}

// External coupling, also known as content coupling, occurs when modules depend on external elements such as 
// specific file formats, database schemas, or external libraries.
// to resolve this problem we can use ap abstract class