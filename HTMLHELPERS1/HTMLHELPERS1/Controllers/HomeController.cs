using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HTMLHELPERS1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Save(Models.ViewModels.PeopleViewModels models)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Success", models);
            }

            return RedirectToAction(nameof(Mostrar), models);
        }


        public ActionResult Success(Models.ViewModels.PeopleViewModels models)
        {
            if (models == null)
                models = new Models.ViewModels.PeopleViewModels();

            return View();
        }
        public ActionResult Mostrar(Models.ViewModels.PeopleViewModels models)
        {


            return View(models);
        }
    }
}