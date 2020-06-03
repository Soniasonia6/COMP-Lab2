using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Lab2.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details(string category)
        {
           
            // store the selected category name in the ViewBagg container
            //ViewBag is automatically passed back to the view that loads
            ViewBag.category = category;
            return View();
    }
}
}
