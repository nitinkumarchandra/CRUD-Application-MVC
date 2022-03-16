using Crud_Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Crud_Application.Controllers
{
    public class HomeController : Controller
    {
        DatabaseFirstApproachEntities2 Db = new DatabaseFirstApproachEntities2();
        public ActionResult Index()
        {
            var data = Db.Students.ToList();
            return View(data);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Student e)
        {
            if (ModelState.IsValid)
            {
                Db.Students.Add(e);
            }
            Db.SaveChanges();
            return RedirectToAction("Index");
            return View(e);
        }
    }
}