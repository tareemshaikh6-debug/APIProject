using API.Repository.Models;

namespace API.Repository.Interface
{
    public interface IEmployeeRepository
    {
        Task<Employees> AddEmployee(Employees employee);
        Task<IEnumerable<Employees>> AllEmp();
        Task<Employees> GetEmployeeById(int id);
        Task<Employees> DeleteById(int id);
        Task<Employees> UpdateEmployee(Employees employee);
    }
}
