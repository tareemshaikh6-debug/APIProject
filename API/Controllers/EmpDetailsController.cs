using API.Repository.Models;
using API.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class EmpDetailsController(IEmpDetailsServices empDetails) : Controller
    {
        [HttpPost("EmpAllDetails")]
        public async Task<IActionResult> EmpAllDetails(int id)
        {
           var result = await empDetails.AllDetails(id);
            return Ok(result);

        }
    }
}
