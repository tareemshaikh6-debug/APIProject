using API.Repository.Models;
using API.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class RoleController(IRoleServices roleServices) : Controller
    {
        [HttpPost("AddRole")]
        public async Task<ActionResult> AddRole(Role role)
        {
            var result = await roleServices.AddRole(role);
            return Ok(result);
        }

        [HttpGet("GetAllRole")]
        public async Task<ActionResult> GetAllRole()
        {
            var result = await roleServices.SelectAll();
            return Ok(result);
        }

        [HttpGet("GetById")]
        public async Task<ActionResult> GetById(int id)
        {
            var result = await roleServices.GetRoleById(id);
            return Ok(result);
        }

        [HttpPost("DeletedById")]
        public async Task<ActionResult> DeletedById(int id)
        {
            var result = await roleServices.DeleteById(id);
            return Ok(result);
        }

        [HttpPost("UpdateRole")]
        public async Task<ActionResult> UpdateRole(Role role)
        {
            var result = await roleServices.UpdateRole(role);
            return Ok(result);
        }

    }
}
