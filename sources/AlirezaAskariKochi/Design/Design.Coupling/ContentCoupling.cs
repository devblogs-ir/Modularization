using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Coupling
{
    public class ContentCoupling
    {
        public class ModuleA
        {
            private int _internalData = 10;

            public void ChangeInternalData(ModuleB b)
            {
                b._internalData = 20;
            }
        }

        public class ModuleB
        {
            internal int _internalData = 5;
        }

    }
}
