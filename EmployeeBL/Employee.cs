using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using EmployeeBL.Abstracts;
using Newtonsoft.Json.Linq;
using WebApplication3.Models;

namespace EmployeeBL
{
    public class Employee : IEmployee
    {

        public IList<Employees> CreateProjectModified()
        {
            //string baseUrl = "http://masglobaltestapi.azurewebsites.net/api/Employees";

            string baseUrl = "http://localhost:51320/api/Values?id=2";
            var json = new WebClient().DownloadString(baseUrl);


            JArray PersonArray = JArray.Parse(json);

            IList<Employees> persona = PersonArray.Select(p => new Employees
            {
                name = (string)p["Name"],
                contractTypeName = (string)p["ContractTypeName"],
                roleId = (string)p["RoleId"],
                roleName = (string)p["RoleName"],
                roleDescription = (string)p["RoleDescription"],
                hourlySalary = (int)p["HourlySalary"],
                monthlySalary = (int)p["MonthlySalary"],
                Total= (int)p["Total"]

            }).ToList();

            return persona;
        }


    }
}
