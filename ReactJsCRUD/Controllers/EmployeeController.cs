using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ReactJsCRUD.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ReactJsCRUD.Controllers
{
    [Route("api/Employee")]
    public class EmployeeController : Controller
    {
        EmployeeDataAccess objemployee = new EmployeeDataAccess();
        // GET: api/<controller>
        [HttpGet]
        [Route("Index")]
        public IEnumerable<TblEmployee> Index()
        {
            return objemployee.GetAllEmployee();
        }

        // GET api/<controller>/5
        [HttpGet]
        [Route("Details/{id}")]
        public TblEmployee Details(int id)
        {
            return objemployee.GetEmployeeData(id);
        }

        // POST api/<controller>
        [HttpPost]
        [Route("Create")]
        public int Create(TblEmployee employee)
        {
            return objemployee.AddEmployee(employee);
        }

        // PUT api/<controller>/5
        [HttpPut]
        [Route("Edit")]
        public int Edit(TblEmployee employee)
        {
            return objemployee.UpdateEmployee(employee);
        }

        // DELETE api/<controller>/5
        [HttpDelete]
        [Route("Delete/{id}")]
        public int Delete(int id)
        {
            return objemployee.DeleteEmployee(id);
        }
        // GET city
        [HttpGet]
        [Route("GetCityList")]
        public IEnumerable<TblCities> Details()
        {
            return objemployee.GetCities();
        }
    }
}
