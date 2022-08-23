using eprojectinstruct.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eprojectinstruct.Controllers
{
    public class EmployeeController : BaseController<Employee>
    {
        public EmployeeController(): base(new EProjectDbContext())
        {

        }
    }
}