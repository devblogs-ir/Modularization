using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Design.Coupling
{
    public enum EntityTypeId
    {
        Account = 0,
        CostCenter = 1,
        Project = 2
    }
    public class Log
    {
        public int Id { get; set; }
        public byte EntityTypeId{ get; set; }
        public string? Description { get; set; }
    }
    public partial class BasicService
    {
        internal virtual byte? EntityType
        {
            get { return null; }
        }

        // If missing set common EntityType property in sub services then log insert with null entity type
        protected void InsertLog()
        {
            Log log = new()
            {
                EntityTypeId = (byte)EntityType,
                Description = string.Empty
            };
        }
    }

    public partial class AccountService
    {
        internal override byte? EntityType
        {
            get { return (byte?)EntityTypeId.Account; }
        }
    }

    public class CostCenterService : BasicService
    {
        internal override byte? EntityType
        {
            get { return (byte?)EntityTypeId.CostCenter; }
        }
    }

    public class ProjectService : BasicService
    {
        internal override byte? EntityType
        {
            get { return (byte?)EntityTypeId.Project; }
        }
    }

}
