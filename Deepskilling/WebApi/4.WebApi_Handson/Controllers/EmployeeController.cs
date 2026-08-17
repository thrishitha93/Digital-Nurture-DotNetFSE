using Microsoft.AspNetCore.Mvc;
using _4.WebApi_Handson.Models;

namespace _4.WebApi_Handson.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private static List<Employee> employees = new List<Employee>
        {
            new Employee
            {
                Id = 1,
                Name = "John",
                Salary = 50000,
                Permanent = true
            },

            new Employee
            {
                Id = 2,
                Name = "Smith",
                Salary = 45000,
                Permanent = false
            },

            new Employee
            {
                Id = 3,
                Name = "David",
                Salary = 60000,
                Permanent = true
            }
        };

        [HttpPut("{id}")]
        public ActionResult<Employee> UpdateEmployee(int id, [FromBody] Employee employee)
        {
            if (id <= 0)
            {
                return BadRequest("Invalid employee id");
            }

            var existingEmployee = employees.FirstOrDefault(e => e.Id == id);

            if (existingEmployee == null)
            {
                return BadRequest("Invalid employee id");
            }

            existingEmployee.Name = employee.Name;
            existingEmployee.Salary = employee.Salary;
            existingEmployee.Permanent = employee.Permanent;

            return Ok(existingEmployee);
        }
    }
}