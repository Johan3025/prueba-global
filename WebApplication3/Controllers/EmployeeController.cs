using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Net;
using System.Data;
using Newtonsoft.Json.Linq;
using WebApplication3.Models;
using EmployeeBL.Abstracts;
using Autofac;
using EmployeeBL;

namespace WebApplication3.Controllers
{
    public class EmployeeController : Controller
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
