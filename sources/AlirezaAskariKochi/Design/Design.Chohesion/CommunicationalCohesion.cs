using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Chohesion
{
    public class CommunicationalCohesion
    {
        private DataSet data;

        public CommunicationalCohesion(DataSet reportData)
        {
            data = reportData;
        }

        public void GeneratePDFReport() { /* Uses data */ }
        public void GenerateHTMLReport() { /* Uses same data */ }
    }
}
