using API.Repository.Models;

namespace API.Services.Interface
{
    public interface ICompanyServices
    {
        Task<Company> AddCompany(Company company);
        Task<IEnumerable<Company>> GetAllCompanies();
        Task<Company> UpdateById(Company company);
        Task<Company> GetById(int id);
        Task<Company> DeleteById(int id);


    }
}
