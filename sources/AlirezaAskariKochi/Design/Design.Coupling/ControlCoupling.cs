using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Design.Coupling.CommonCoupling;

namespace Design.Coupling
{
    public class ControlCoupling
    {
        public class ModuleA
        {
            public void ProcessData(bool flag)
            {
                if (flag)
                {
                    Console.WriteLine("Process data one way");
                }
                else
                {
                    Console.WriteLine("Process data another way");                    
                }
            }
        }

        public class ModuleB
        {
            public void ControlOtherModule()
            {
                var a = new ModuleA();
                a.ProcessData(true); 
            }
        }

    }
}
