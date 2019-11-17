using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Autofac;
using EmployeeBL;
using EmployeeBL.Abstracts;

namespace WebApplication3.Controllers
{
    public class EmployeesController : Controller
    {
        // GET: Employees
        public ActionResult Index()
        {
            var app = new ContainerBuilder();
            app.RegisterType<Employee>().As<IEmployee>();
            var builder = app.Build();
            var _employee = builder.Resolve<IEmployee>();
            var test = _employee.CreateProjectModified();
            return View(test);
        }

 
    }
}