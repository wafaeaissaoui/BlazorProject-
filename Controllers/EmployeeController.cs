using BlazorApp2.DataAccessLayer;
using BlazorApp2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
namespace BlazorApp2.Controllers
{
    public class EmployeeController : ControllerBase
    {
        IEmployee _employee;

        public EmployeeController(IEmployee employee)
        {
            _employee = employee;
        }

        [HttpGet]
        [Route("api/Employee/Index")]
        public IEnumerable Index()
        {
            return _employee.GetEmployes();
        }

    }
}
