using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assignment6.Data;
using Assignment6.Data.Entity_Models;
using System.Net;
using System.Data.Entity;
using Assignment6.Services;
using Autofac;

namespace Assignment6.Web.Controllers
{
    public class HomeController : Controller
    {
        private EmpContext db = new EmpContext();

        // GET: Home
        private readonly IEmployeeService employeeservice;

        public ActionResult Index()
        {
            return View(db.Emp1.ToList());
        }
        public HomeController(IEmployeeService employeeService)
        {
            this.employeeservice = employeeService;
        }
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee1 emp = db.Emp1.Find(id);
            if (emp == null)
            {
                return HttpNotFound();
            }
            return View(emp);
        }

        // POST: Products/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EId,EName,Email,Phone,MaritalStatus,State,City")] Employee1 emp)
        {
            if (ModelState.IsValid)
            {
                db.Emp1.Add(emp);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(emp);
        }

        // GET: Products/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee1 employee = db.Emp1.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EId,EName,Email,Phone,MaritalStatus,State,City")] Employee1 employee)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employee).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employee);
        }

        // GET: Products/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee1 emp = db.Emp1.Find(id);
            if (emp == null)
            {
                return HttpNotFound();
            }
            return View(emp);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Employee1 product = db.Emp1.Find(id);
            db.Emp1.Remove(product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}