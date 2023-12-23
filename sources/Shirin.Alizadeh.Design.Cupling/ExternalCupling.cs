namespace Shirin.Alizadeh.Design.Cupling;

using System;


class DataCouplingExample
{
    class DataClass
    {
        public int Value1;
        public string Value2;

    }

    class DataProcessorA
    {

        // private ExternalLibrary _externalLibraryDependancy;
        //public DataProcessorA(ExternalLibrary  externalLibraryDependancy)
        //{
        //    _externalLibraryDependancy=externalLibraryDependancy;
        //}
        DataProcessorB _dependancy =new DataProcessorB();
        public void DataProcessor(DataClass data )
        {
            _dependancy.DoAction(data);
        }

    }
    //interface  IExternalLibraryDependancy
    //{
    //    public void DoAction(Object object)
    //    {
    //        /// do
    //    }

    //}


}
