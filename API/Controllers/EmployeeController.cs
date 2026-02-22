using API.Repository.Models;
using API.Services.Interface;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    public class EmployeeController(IEmployeeServices employee) : ControllerBase
    {
        [HttpPost("AddEmp")]
        public async Task<IActionResult> AddEmployee(Employees employees)
        {
            var emp = await employee.AddEmployee(employees);
            return Ok(emp);

        }

        [HttpGet("AllEmp")]
        public async Task<IActionResult> AllEmp()
        {
            var emp = await employee.AllEmp();
            return Ok(emp);
        }

        [HttpPost("GetById")]
        public async Task<IActionResult> GetEmployeeById(int id)
        {
            var emp = await employee.GetEmployeeById(id);
            return Ok(emp);
        }
        [HttpPost("DeleteEmpById")]
        public async Task<IActionResult> DeleteById(int id)
        {
            var emp = await employee.DeleteById(id);
            return Ok(emp);
        }
        [HttpPatch("UpdateEmpById")]
        public async Task<IActionResult> UpdateEmployee(Employees employees)
        {
            var emp = await employee.UpdateEmployee(employees);
            return Ok(emp);
        }
    }
}