using ModelStateDemo.ViewModels.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ModelStateDemo.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Add()
        {
            AddUserVM model = new AddUserVM();
            return View(model);
        }

        [HttpPost]
        public ActionResult Add(AddUserVM model)
        {
            if(model.FirstName == model.LastName)
            {
                ModelState.AddModelError("LastName", "The last name cannot be the same as the first name.");
            }
            if(!ModelState.IsValid)
            {
                return View(model);
            }
            return RedirectToAction("Index");
        }
    }
}