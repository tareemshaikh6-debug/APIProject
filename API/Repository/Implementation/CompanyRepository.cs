
using System.Data;
using System.Data.SqlClient;
using API.Repository.Interface;
using API.Repository.Models;
using Dapper;
using Microsoft.AspNetCore.Http.HttpResults;

namespace API.Repository.Implementation
{
    public class CompanyRepository : ICompanyRepository
    {
      
        //Add Company
        public async Task<Company> AddCompany(Company company)
        {
          using(SqlConnection con=new SqlConnection(ConnectionString.cs))
          {
                string query= "spAddCompany";
                SqlCommand cmd=new SqlCommand(query,con);
                cmd.CommandType=CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id",company.CompanyId);
                cmd.Parameters.AddWithValue("@companyname",company.CompanyName);
                cmd.Parameters.AddWithValue("@companyaddress",company.CompanyAddress);
                cmd.Parameters.AddWithValue("@foundername",company.FounderName);
                cmd.Parameters.AddWithValue("@createdby",company.CompanyId);
                cmd.Parameters.AddWithValue("@createdon",company.CreatedOn);
                cmd.Parameters.AddWithValue("@isactive",company.IsActive);
                con.Open();
                await cmd.ExecuteNonQueryAsync();
                return company;
          }
        }


        //Delete Company by Id
        public Task<Company> DeleteById(int id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.cs))
            {
                string query = "spDeleteCompany";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", id);
                connection.Open();
                cmd.ExecuteNonQuery();
                return Task.FromResult(new Company());
            }
        }



        //Get All Companies
        public async Task<IEnumerable<Company>> GetAllCompanies()
        {
            using(SqlConnection con=new SqlConnection(ConnectionString.cs))
            {
                string query= "spGetCompany";
                var companies=await con.QueryAsync<Company>(query,commandType:CommandType.StoredProcedure);
                return companies;
            }
        }



        //Get Company by Id
        public Task<Company> GetById(int id)
        {

            using (SqlConnection con = new SqlConnection(ConnectionString.cs))
            {
                string query = "GetById";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", id);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                Company company = new Company();
                if (reader.Read())
                {
                    company.CompanyId = Convert.ToInt32(reader["CompanyId"]);
                    company.CompanyName = reader["CompanyName"].ToString();
                    company.CompanyAddress = reader["CompanyAddress"].ToString();
                    company.FounderName = reader["FounderName"].ToString();
                    company.CreatedBy = Convert.ToInt32(reader["CreatedBy"]);
                    company.CreatedOn = Convert.ToDateTime(reader["CreatedOn"]);
                    company.IsActive = Convert.ToBoolean(reader["IsActive"]);
                }
                return Task.FromResult(company);

            }
        }



        //Update Company by Id
        public Task<Company> UpdateById(Company company)
        {
            using(SqlConnection con=new SqlConnection(ConnectionString.cs))
            {
                string query= "spUpdateCompany";
                SqlCommand cmd=new SqlCommand(query,con);
                cmd.CommandType=CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id",company.CompanyId);
                cmd.Parameters.AddWithValue("@companyname",company.CompanyName);
                cmd.Parameters.AddWithValue("@companyaddress",company.CompanyAddress);
                cmd.Parameters.AddWithValue("@foundername",company.FounderName);
                cmd.Parameters.AddWithValue("@updatedby",company.CompanyId);
                cmd.Parameters.AddWithValue("@updatedon",company.UpdatedOn);
                cmd.Parameters.AddWithValue("@isactive",company.IsActive);
                con.Open();
                cmd.ExecuteNonQuery();
                return Task.FromResult(company);
            }
        }
    }
}
