using API.Repository.Models;

namespace API.Services.Interface
{
    public interface IRoleServices
    {
        Task<Role> AddRole(Role role);

        Task<IEnumerable<Role>> SelectAll();
        Task<Role> GetRoleById(int id);

        Task<Role> DeleteById(int id);

        Task<Role> UpdateRole(Role role);
    }
}
