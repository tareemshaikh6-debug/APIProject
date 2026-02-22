using API.Repository.Models;

namespace API.Repository.Interface
{
    public interface IRoleRepository
    {
        Task<Role> AddRole(Role role);

        Task<IEnumerable<Role>> SelectAll();

        Task<Role> GetRoleById(int id);
        Task<Role> DeleteById(int id);
        Task<Role> UpdateRole(Role role);

    }
}
