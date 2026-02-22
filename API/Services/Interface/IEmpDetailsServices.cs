using API.Repository.Models;

namespace API.Services.Interface
{
    public interface IEmpDetailsServices
    {
        Task<EmpDetails> AllDetails(int id);
    }
}
