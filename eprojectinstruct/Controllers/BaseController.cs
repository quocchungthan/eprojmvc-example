using eprojectinstruct.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace eprojectinstruct.Controllers
{
    public abstract class BaseController<T>: Controller
        where T : class
    {

        protected EProjectDbContext _dbContext;

        public BaseController(EProjectDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        // GET: Product
        public async Task<ActionResult> Index()
        {
            var countProducts = await Set().CountAsync();

            ViewBag.Message = $"Number of products: {countProducts}";

            return View();
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        public async Task<ActionResult> Create(T productForm)
        {
            try
            {
                Set().Add(productForm);
                await _dbContext.SaveChangesAsync();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // Generic method
        private DbSet<T> Set()
        {
            var typeOfSet = typeof(DbSet<T>);
            // Reflection
            var dbsetProperty = typeof(EProjectDbContext).GetProperties().Where(x => x.PropertyType.IsEquivalentTo(typeOfSet)).FirstOrDefault();

            return dbsetProperty.GetValue(_dbContext) as DbSet<T>;
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}