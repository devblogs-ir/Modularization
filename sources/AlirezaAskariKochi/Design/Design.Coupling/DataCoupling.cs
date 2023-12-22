using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Coupling
{
    public class DataCoupling
    {
        public class ModuleA
        {
            public void ProcessData(int data)
            {
                Console.WriteLine($"Process data {data}");
            }
        }

        public class ModuleB
        {
            public void SendData()
            {
                var a = new ModuleA();
                a.ProcessData(5); 
            }
        }

    }
}
