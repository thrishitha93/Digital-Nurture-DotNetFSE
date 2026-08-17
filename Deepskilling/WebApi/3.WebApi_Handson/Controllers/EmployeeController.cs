using Microsoft.AspNetCore.Mvc;
using _3.WebApi_Handson.Models;

namespace _3.WebApi_Handson.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<List<Employee>> Get()
        {
            return GetStandardEmployeeList();
        }

        private List<Employee> GetStandardEmployeeList()
        {
            return new List<Employee>
            {
                new Employee
                {
                    Id = 1,
                    Name = "John",
                    Salary = 50000,
                    Permanent = true,
                    Department = new Department
                    {
                        Id = 1,
                        Name = "IT"
                    },
                    Skills = new List<Skill>
                    {
                        new Skill { Id = 1, Name = "C#" },
                        new Skill { Id = 2, Name = "SQL" }
                    },
                    DateOfBirth = new DateTime(1998, 5, 10)
                },

                new Employee
                {
                    Id = 2,
                    Name = "Smith",
                    Salary = 45000,
                    Permanent = false,
                    Department = new Department
                    {
                        Id = 2,
                        Name = "HR"
                    },
                    Skills = new List<Skill>
                    {
                        new Skill { Id = 3, Name = "Communication" }
                    },
                    DateOfBirth = new DateTime(1999, 8, 15)
                }
            };
        }

        [HttpPost]
        public ActionResult<Employee> Post([FromBody] Employee employee)
        {
            return Ok(employee);
        }

        [HttpPut("{id}")]
        public ActionResult<Employee> Put(int id, [FromBody] Employee employee)
        {
            employee.Id = id;
            return Ok(employee);
        }
    }
}