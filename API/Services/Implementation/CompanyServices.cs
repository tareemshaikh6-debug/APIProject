using API.Repository.Interface;
using API.Repository.Models;
using API.Services.Interface;

namespace API.Services.Implementation
{
    public class CompanyServices(ICompanyRepository companyRepository):ICompanyServices
    {   
        public async Task<Company> AddCompany(Company company)
        {
            var result = await companyRepository.AddCompany(company);
            return result;
        }

        public Task<Company> DeleteById(int id)
        {
            var result = companyRepository.DeleteById(id);
            return result;
        }

        public async Task<IEnumerable<Company>> GetAllCompanies()
        {
            var result = await companyRepository.GetAllCompanies();
            return result;
        }

        public Task<Company> GetById(int id)
        {
           var result = companyRepository.GetById(id);
            return result;  
        }

        public Task<Company> UpdateById(Company company)
        {
            var result = companyRepository.UpdateById(company);
            return result;
        }   
    }
}
