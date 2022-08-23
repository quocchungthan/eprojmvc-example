using eprojectinstruct.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;

namespace eprojectinstruct.Controllers
{
    public class ProductController : BaseController<Product>
    {

        public ProductController(): base(new EProjectDbContext())
        {
        }
    }
}
