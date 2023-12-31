using Design.Coupling;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Design.Cohesion
{
    public class ChecksController : ControllerBase
    {
        [HttpPost]
        public IActionResult PostCheck(Check check) 
        {
            // if user choose account then validation full account
            if(check.Account != null && check.Account.Id > 0) 
            {
                AccountValidation(check.Account);
                DetailAccountValidation(check.DetailAccount);
                CostCenterValidation(check.CostCenter);
                ProjectValidation(check.Project);
            }
            //Insert check
            return Ok();
        }

        public IActionResult AccountValidation(Account account) 
        { 
            //Validation
            return Ok();
        }

        public IActionResult DetailAccountValidation(DetailAccount detailAccount)
        {
            //Validation
            return Ok();
        }

        public IActionResult CostCenterValidation(CostCenter costCenter)
        {
            //Validation
            return Ok();
        }

        public IActionResult ProjectValidation(Project project)
        {
            //Validation
            return Ok();
        }

    }

    public class Check
    {
        public Account Account { get; set; }
        public Project Project { get; set; }
        public DetailAccount DetailAccount { get; set; }
        public CostCenter CostCenter { get; set; }
    }

    public class CostCenter
    {
        public int Id { get; set; }
        public int Name { get; set; }
    }

    public class Project
    {
        public int Id { get; set; }
        public int Name { get; set; }
    }

    public class DetailAccount
    {
        public int Id { get; set; }
        public int Name { get; set; }
    }
}
