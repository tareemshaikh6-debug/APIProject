using API.Repository.Models;

namespace API.Repository.Interface
{
    public interface ICompanyRepository
    {
        Task<Company> AddCompany(Company company);

        Task<IEnumerable<Company>> GetAllCompanies();

        Task<Company> UpdateById(Company company);

        //Task<Company> DeleteCompany(Company company);
        Task<Company> DeleteById(int id);

        Task<Company> GetById(int id);
    }
}
