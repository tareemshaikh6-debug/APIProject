using API.Repository.Interface;
using API.Repository.Models;
using API.Services.Interface;

namespace API.Services.Implementation
{
    public class EmployeeServices(IEmployeeRepository employeeRepository) : IEmployeeServices
    {
        public async Task<Employees> AddEmployee(Employees employee)
        {
            var result = await employeeRepository.AddEmployee(employee);
            return result;
        }

        public Task<IEnumerable<Employees>> AllEmp()
        {
           var result= employeeRepository.AllEmp();
           return result;
        }

        public Task<Employees> DeleteById(int id)
        {
            var result = employeeRepository.DeleteById(id);
            return result;
        }

        public async Task<Employees> GetEmployeeById(int id)
        {
            var result = await employeeRepository.GetEmployeeById(id);
            return result;
        }

        public Task<Employees> UpdateEmployee(Employees employee)
        {
           var result= employeeRepository.UpdateEmployee(employee);
              return result;
        }
    }
}
