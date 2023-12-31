using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Coupling
{
    public class CommonCoupling
    {
        public static class GlobalData
        {
            public static int SharedData = 0;
        }

        public class ModuleA
        {
            public void ChangeData()
            {
                GlobalData.SharedData = 10;
            }
        }

        public class ModuleB
        {
            public void DisplayData()
            {
                Console.WriteLine(GlobalData.SharedData);
            }
        }

    }
}
