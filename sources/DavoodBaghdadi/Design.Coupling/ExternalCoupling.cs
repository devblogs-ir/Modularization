using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Coupling
{
    public class ExternalCoupling
    {
        public bool ReadFromFile(string filePath, bool canRead)
        {
            if (canRead)
            {
                //Some Codes 
                return true;
            }
            else
            {
                //Some Codes 
                return false;
            }

        }
        public void AppendTextToFile(string filePath, string newText)
        {
            //Append newText to file
        }

        public bool ExternallyCoupledMethod(string filePath, string text)
        {
            //Checking for added some texts is completly connectod to external file
            if (ReadFromFile(filePath, true))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
