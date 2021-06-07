using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ADONET_MVC_PROJECT.DAL;
using ADONET_MVC_PROJECT.Models;


using System.Configuration;


namespace ADONET_MVC_PROJECT.Controllers
{
    public class employeeController : Controller
    {
        employeerepository rep = new employeerepository();
        // GET: employee
        public ActionResult Index()
        {
           
            var list = rep.Disp_Rec();

            return View(list);
        }

        // GET: employee/Details/5
        public ActionResult Details(int id)
        {
            
                var sss = rep.Find_Rec(id);
                return View(sss);
            
           
        }

        // GET: employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: employee/Create
        [HttpPost]
        public ActionResult Create(employee emp)
        {
            try
            {
                rep.Save_Rec(emp);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: employee/Edit/5
        public ActionResult Edit(int id)
        {
            var sss = rep.Find_Rec(id);
            return View(sss);
        }

        // POST: employee/Edit/5
        [HttpPost]
        public ActionResult Edit(employee emp)
        {
            try
            {
                rep.Update_Rec(emp);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: employee/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: employee/Delete/5
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
