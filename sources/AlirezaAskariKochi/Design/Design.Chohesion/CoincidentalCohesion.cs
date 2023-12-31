using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Chohesion
{
    public class CoincidentalCohesion
    {
        public void PrintDate()
        {
            Console.WriteLine(DateTime.Now);
        }

        public int Add(int a, int b)
        {
            return a + b;
        }

        public void SaveToFile(string data)
        {
            File.WriteAllText("file.txt", data);
        }
    }
}
