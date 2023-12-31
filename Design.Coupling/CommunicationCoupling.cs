using Dumpify;

namespace Design.Coupling;

public class CommunicationCoupling
{
    TestModel model = new() { Name = "Test" ,PhonNum = "09876543221"};
    public string RegisterModel()
    {
        RegiterCode sender = new RegiterCode();
        return sender.SendRegisterCode(model, "1234");
    }
}
public class TestModel
{
    public required string  Name { get; set; }
    public required string PhonNum { get; set; }
}
public class RegiterCode
{
    public string SendRegisterCode(TestModel reciver , string registerCode)
    {
        return $"{reciver.Name} Your code is {registerCode}".Dump();
    }
}

