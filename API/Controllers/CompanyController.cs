using API.Repository.Interface;
using API.Repository.Models;
using API.Services.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
   // [ApiController]
    public class CompanyController(ICompanyServices companyServices) : Controller
    {

        
        [HttpPost("AddCompanies")]
        
        public async Task<ActionResult<Company>> AddCompanies(Company company)
        {

            var result = await companyServices.AddCompany(company);
            return Ok(result);
        }
        [HttpGet("GetAllCompany")]
        public async Task<ActionResult<IEnumerable<Company>>> GetAllCompanies()
        {
            var result = await companyServices.GetAllCompanies();
            return Ok(result);
        }
        [HttpGet("GetCompanyById")]
        public async Task<ActionResult<Company>> GetCompanyById(int id)
        {
            var result = await companyServices.GetById(id);
            return Ok(result);
        }
        [HttpPost("UpdatedById")]
        public async Task<ActionResult<Company>> UpdatedById(Company company)
        {
            var result = await companyServices.UpdateById(company);
            return Ok(result);
        }

        [HttpPost("DeleteById")]
        public async Task<ActionResult<Company>> DeleteById(int id)
        {
            var result = await companyServices.DeleteById(id);
            return Ok(result);
        }
       
    }
}
