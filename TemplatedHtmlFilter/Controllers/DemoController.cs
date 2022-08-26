using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TemplatedHtmlFilter.Models;

namespace TemplatedHtmlFilter.Controllers
{
    public class DemoController : Controller
    {

        // GET: Demo
        public ActionResult Index()
        {
            Employee emp = new Employee()
            {
                Id = 1,
                name = "Neha",
                email = "neha@gmail.com",
                IsOnline = false,
                dob = DateTime.Now
            };
            return View(emp);
        }

        public ActionResult Edit()
        {
            
            return View();
        }
    }
}