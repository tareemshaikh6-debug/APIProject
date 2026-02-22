using API.Repository.Interface;
using API.Repository.Models;
using API.Services.Interface;

namespace API.Services.Implementation
{
    public class RoleServices(IRoleRepository roleRepository) : IRoleServices
    {
        public async Task<Role> AddRole(Role role)
        {
            var result=await roleRepository.AddRole(role);
            return result;
        }

        public async Task<Role> DeleteById(int id)
        {
            var rsult=await roleRepository.DeleteById(id);
            return rsult;
        }

        public async Task<Role> GetRoleById(int id)
        {
           var result=await roleRepository.GetRoleById(id);
            return result;
        }


        public async Task<IEnumerable<Role>> SelectAll()
        {
            var result = await roleRepository.SelectAll();
            return result;
        }

        public async Task<Role> UpdateRole(Role role)
        {
            var result=await roleRepository.UpdateRole(role);
            return result;
        }
    }
}
