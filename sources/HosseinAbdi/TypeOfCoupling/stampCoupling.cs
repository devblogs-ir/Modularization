public class School
{
    public int Id { get; set; } 
    public string Name { get; set; }
    public string Address{get;set;}
    public string Type{get;set;}

}
public class Student 
{
    public int Id { get; set; }
    public string FullName { get; set; }  
    public void GetSchoolInfo(int id,string name,string address,string type)
    {
        var model=new School
        {
            Id=id,
            Name=name,
            Address=address,
            Type=type
        };
        ShowSchoolInfo(model);
    }  
    public void ShowSchoolInfo (School model)               //we send a model as parameter to the function , actully we dont need address and type of school    
    {
         string schoolinfo=$"{model.Name} + {model.Id} "; 
    }
}