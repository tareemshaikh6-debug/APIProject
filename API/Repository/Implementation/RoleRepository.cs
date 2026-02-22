using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using API.Repository.Interface;
using API.Repository.Models;
using Dapper;

namespace API.Repository.Implementation
{
    public class RoleRepository : IRoleRepository
    {


        //Add Role
        public async Task<Role> AddRole(Role role)
        {
           using(SqlConnection con=new SqlConnection(ConnectionString.cs))
            {
                string query = "AddRole";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("id", role.Id);
                cmd.Parameters.AddWithValue("RoleName", role.Rolename);
                cmd.Parameters.AddWithValue("RoleDescription", role.RoleDescription);
                cmd.Parameters.AddWithValue("CreatedBy", role.Id);
                cmd.Parameters.AddWithValue("Createdon", role.CreatedOn);
                cmd.Parameters.AddWithValue("IsActive", role.IsActive);
                con.Open();
                await cmd.ExecuteNonQueryAsync();
                return role;
            }
          
        }


        //Delete Role by Id
        public async Task<Role> DeleteById(int id)
        {
            using(SqlConnection con=new SqlConnection(ConnectionString.cs))
            {
                string query= "spDeleteRole";
                SqlCommand cmd=new SqlCommand(query,con);
                cmd.CommandType=CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id",id);
                con.Open();
                await cmd.ExecuteNonQueryAsync();
                return new Role();
            }
        }


        //Get Role by Id
        public Task<Role> GetRoleById(int id)
        {
            using(SqlConnection con=new SqlConnection(ConnectionString.cs))
            {
                string query= "spGetRoleById";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", id);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                Role role = new Role();
                if (reader.Read())
                {
                    role.Id = Convert.ToInt32(reader["Id"]);
                    role.Rolename = reader["RoleName"].ToString();
                    role.RoleDescription = reader["RoleDescription"].ToString();
                    role.CreatedBy = Convert.ToInt32(reader["CreatedBy"]);
                    role.CreatedOn = Convert.ToDateTime(reader["CreatedOn"]);
                    role.IsActive = Convert.ToBoolean(reader["IsActive"]);
                }
                return Task.FromResult(role);
            }
        }


        //Get All Roles
        public async Task<IEnumerable<Role>> SelectAll()
        {
            using(SqlConnection con=new SqlConnection(ConnectionString.cs))
            {
                string query= "GetAllRole";
                var roles=await con.QueryAsync<Role>(query,commandType:CommandType.StoredProcedure);
                return roles;
            }
        }



        //Update Role
        public async Task<Role> UpdateRole(Role role)
        {
            using(SqlConnection con=new SqlConnection(ConnectionString.cs))
            {
                string query = "spUpdaterole";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("id", role.Id);
                cmd.Parameters.AddWithValue("RoleName", role.Rolename);
                cmd.Parameters.AddWithValue("RoleDescription", role.RoleDescription);
                cmd.Parameters.AddWithValue("UpdatedBy", role.Id);
                cmd.Parameters.AddWithValue("Updatedon", role.UpdatedOn);
                cmd.Parameters.AddWithValue("IsActive", role.IsActive);
                con.Open();
                await cmd.ExecuteNonQueryAsync();
                return role;
            }
        }
    }
}
