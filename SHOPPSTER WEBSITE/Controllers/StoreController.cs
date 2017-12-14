using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SHOPPSTER_WEBSITE.Models;

namespace SHOPPSTER_WEBSITE.Controllers
{
    public class StoreController : Controller
    {
        ShoppsterEntities storeDB = new ShoppsterEntities();
        // GET: Store
        public ActionResult Index()
        {
            var categories = storeDB.Categories.ToList();
           
            return View(categories);
        }
        public ActionResult Browse(string category)
        {
            var  catagoryModel = storeDB.Categories.Include("Items").Single(c => c.Name == category);
            return View(catagoryModel);
        }
        public ActionResult Details(int id)
        {
            var Item = new Item { Title = "Item" + id };
            return View(Item);
        }
    }
}