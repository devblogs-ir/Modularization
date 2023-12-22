using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Chohesion
{
    internal class TemporalCohesion
    {
        public void Initialize()
        {
            LoadConfigurations();
            EstablishDatabaseConnection();
            CheckForUpdates();
        }

        private void LoadConfigurations() { /*...*/ }
        private void EstablishDatabaseConnection() { /*...*/ }
        private void CheckForUpdates() { /*...*/ } 
    }
}
