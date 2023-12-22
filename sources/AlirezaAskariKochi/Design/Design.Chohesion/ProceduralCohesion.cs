using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Chohesion
{
    internal class ProceduralCohesion
    {
        public void ProcessOrder()
        {
            ValidateOrder();
            CalculateTotal();
            SaveOrder();
            SendConfirmationEmail();
        }

        private void ValidateOrder() { /*...*/ }
        private void CalculateTotal() { /*...*/ }
        private void SaveOrder() { /*...*/ }
        private void SendConfirmationEmail() { /*...*/ }
    }

}
