using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Details()
        {
            Employee emp = new Employee()
            {
                EmployeeId = 102,
                Name = "Sajid",
                Gender = "Male",
                City = "Paris"
            };
            return View(emp);
        }
    }
}

            
