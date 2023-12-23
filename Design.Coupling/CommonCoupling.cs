using System;
using System.Collections.Generic;
using System.Linq;

namespace Design.Coupling;

public class CommonCoupling
{
    private readonly TestRepository _repository;
    public CommonCoupling(TestRepository repository)
    {
        _repository = repository;
    }
    public List<string> Add()
    {
        _repository.CreateString("test");
        _repository.CreateString("test");

        return _repository.GetAllString();
    }
}
public class TestRepository
{
    private List<string> _context;
    public TestRepository()
    {
        _context = new List<string>();
    }
    public void CreateString(string model)
    {
        _context.Add(model);
    }
    public List<string> GetAllString()
    {
        return _context;
    }
}

