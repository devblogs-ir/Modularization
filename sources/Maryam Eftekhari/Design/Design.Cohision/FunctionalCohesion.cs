using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Cohesion
{
    public partial class BasicService
    {
        /// <summary>
        /// A public method for group delete in sub classes
        /// </summary>
        /// <param name="entities">list of entities</param>
        protected void GroupDelete<Entity>(IList<Entity> entities)
        {
            
        }

        /// <summary>
        /// A public method for insert log in sub classes 
        /// </summary>
        /// <param name="entity"></param>
        protected void InsertLog<Entity>(Entity entity)
        {
        }

        /// <summary>
        /// A public method for finalize database task in sub classes 
        /// </summary>
        /// <param name="entity"></param>
        protected void Finalize()
        {
        }
    }
}
