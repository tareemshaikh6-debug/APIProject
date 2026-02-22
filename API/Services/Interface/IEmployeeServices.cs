using API.Repository.Models;

namespace API.Services.Interface
{
    public interface IEmployeeServices
    {
        Task<Employees> AddEmployee(Employees employee);
        Task<IEnumerable<Employees>> AllEmp();
        Task<Employees> GetEmployeeById(int id);
        Task<Employees> DeleteById(int id);
        Task<Employees> UpdateEmployee(Employees employee);
    }
}
