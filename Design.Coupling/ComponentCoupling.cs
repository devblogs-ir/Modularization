
using Dumpify;

namespace Design.Coupling;

public class ComponentCoupling
{
    private RepositoryComponent _component = new();
    public void AddUser(User model)
    {
        _component.AddUser(model);
    }

}
public class User
{
    public required string Name { get; set; }
}
public class UnitOfWorkComponent
{
    public void Save()
    {
        "Save data".Dump();
    }
}
public class RepositoryComponent
{
    private UnitOfWorkComponent unitOfWorkComponent;
    public RepositoryComponent()
    {
        unitOfWorkComponent = new UnitOfWorkComponent();
    }
    public void AddUser(User model)
    {
        unitOfWorkComponent.Save();
        $"{model.Name} added".Dump();
    }
    
}
