namespace Shirin.Alizadeh.Design.Cupling;

using System;

public class ProcessDataA
{
    private int internalData;

    public void SetData(int data)
    {
        internalData = data;
    }

    public int GetData()
    {
        return internalData;
    }
}


public class ProcessDataB
{
    private ProcessDataA _processDataAInstance;

    public ProcessDataB(ProcessDataA processDataAInstance)
    {
        _processDataAInstance = processDataAInstance;
    }

    public void UseModuleAData()
    {
       
        int dataFromprocessDataA = processDataAInstance.GetData();
       
    }
}


class MainApp
{
    static void Main()
    {

        ProcessDataA processDataAInstance = new ProcessDataA();
        ProcessDataB processDataBInstance = new ProcessDataB(processDataAInstance);


        processDataAInstance.SetData(42);


        processDataBInstance.UseModuleAData();
    }
}
