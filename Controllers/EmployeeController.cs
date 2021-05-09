using CodeSample.Models;
using CodeSample.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeSample.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IRepository<Employee> _empRepo;
        public EmployeeController(IRepository<Employee> empRepo)
        {
            _empRepo = empRepo;
        }

        // GET: EmployeeController
        public ActionResult Index()
        {
            var data = _empRepo.GetAll();
            return View(data);
        }

        // GET: EmployeeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EmployeeController/Create
        public ActionResult Create()
        {
            return PartialView("_Create");
        }

        // POST: EmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee collection)
        {
            try
            {
                int result = 0;

                if (collection != null)
                {
                    Employee objEmp = new Employee();
                    objEmp.EmpName = collection.EmpName;
                    objEmp.Address = collection.Address;
                    objEmp.Email = collection.Email;
                    objEmp.Phone = collection.Phone;
                    objEmp.BankAccountNo = collection.BankAccountNo;
                    objEmp.CreatedOn = DateTime.Now;
                    objEmp.CreatedBy = "SYSTEM";
                    objEmp.ModifiedOn = null;
                    objEmp.ModifiedBy = null;
                    result = _empRepo.Add(objEmp).Result;
                }
                else
                    result = 0;
               

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EmployeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmployeeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
