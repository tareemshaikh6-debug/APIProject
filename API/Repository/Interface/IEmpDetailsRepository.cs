using API.Repository.Models;

namespace API.Repository.Interface
{
    public interface IEmpDetailsRepository
    {
        Task<EmpDetails> AllDetails(int id);
        //Task<IEnumerable<EmpDetails>> AllDetails();
    }
}
