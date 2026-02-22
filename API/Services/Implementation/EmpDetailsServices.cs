using API.Repository.Interface;
using API.Repository.Models;
using API.Services.Interface;

namespace API.Services.Implementation
{
    public class EmpDetailsServices(IEmpDetailsRepository empDetails) : IEmpDetailsServices
    {
        public Task<EmpDetails> AllDetails(int id)
        {
            var result = empDetails.AllDetails(id);
            return result;
        }
    }
}
