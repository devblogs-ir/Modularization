namespace Shirin.Alizadeh.Design.Cupling;

using System;
public static class CommonData
{
    public static int SharedValue { get; set; }
}


public class ProcessDataA
{
    public void UseSharedValue()
    {
        int value = CommonData.SharedValue;
    }
}


public class ProcessDataB
{
    public void ModifySharedValue()
    {
     
        CommonData.SharedValue = 42;
    }
}


class MainApp
{
    static void Main()
    {

        ProcessDataA processDataAInstance = new ProcessDataA();
        ProcessDataB processDataBInstance = new ProcessDataB();


        processDataAInstance.UseSharedValue();

        processDataBInstance.ModifySharedValue();

        processDataAInstance.UseSharedValue();
    }
}
