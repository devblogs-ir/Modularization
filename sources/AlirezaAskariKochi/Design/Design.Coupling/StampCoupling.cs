using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Coupling
{
    public class StampCoupling
    {
        public class Data
        {
            public int Part1;
            public int Part2;
        }

        public class ModuleA
        {
            public void ProcessData(Data d)
            {
                Console.WriteLine(d.Part1);
            }
        }

        public class ModuleB
        {
            public void PrepareData()
            {
                var d = new Data { Part1 = 1, Part2 = 2 };
                var a = new ModuleA();
                a.ProcessData(d);
            }
        }
    }
}
