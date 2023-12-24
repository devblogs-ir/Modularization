using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Cohesion
{
    public static class StaticClass
    {
        public static PersianCalendar GetPersianDate(DateTime date)
        {
            return new PersianCalendar();
        }

        public static int GetCurrenFiscalPeriodId() 
        { 
            return 0; 
        }
    }
}
