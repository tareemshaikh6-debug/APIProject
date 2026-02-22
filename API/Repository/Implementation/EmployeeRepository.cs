using System.Data;
using System.Data.SqlClient;
using API.Repository.Interface;
using API.Repository.Models;
using Dapper;

namespace API.Repository.Implementation
{
    public class EmployeeRepository : IEmployeeRepository
    {



        //Add Employee
        public async Task<Employees> AddEmployee(Employees employee)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString.cs))
            {
                string query = "spAddEmp";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("EmpId", employee.EmpId);
                cmd.Parameters.AddWithValue("EmpName", employee.EmpName);
                cmd.Parameters.AddWithValue("JoiningDate", employee.JoiningDate);
                cmd.Parameters.AddWithValue("Salary", employee.Salary);
                cmd.Parameters.AddWithValue("Dob", employee.Dob);
                cmd.Parameters.AddWithValue("Gender", employee.Gender);
                cmd.Parameters.AddWithValue("createdby", employee.EmpId);
                cmd.Parameters.AddWithValue("createdon", employee.CredatedOn);
                cmd.Parameters.AddWithValue("IsActive", employee.IsActive);
                con.Open();
                await cmd.ExecuteNonQueryAsync();
                return employee;
            }
            
        }



        //Get All Employees 
        public async Task<IEnumerable<Employees>> AllEmp()
        {
            using (SqlConnection con = new SqlConnection(ConnectionString.cs))
            {
                string query = "spAllEmp";
                var employees = await con.QueryAsync<Employees>(query, commandType: CommandType.StoredProcedure);
                return employees;


            }
        }



        //Delete Employee By Id
        public Task<Employees> DeleteById(int id)
        {
            using(SqlConnection con = new SqlConnection(ConnectionString.cs))
            {
                string query = "spDeleteById";
                SqlCommand cmd=new SqlCommand(query, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@empid", id);
                con.Open();
                cmd.ExecuteNonQuery();
                return Task.FromResult(new Employees());
            }
            

        }



        //Get Employee By Id
        public Task<Employees> GetEmployeeById(int id)
        {
            using(SqlConnection con = new SqlConnection(ConnectionString.cs))
            {
                string query = "spGetEmpById";
                SqlCommand cmd=new SqlCommand(query, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@empid", id);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                Employees employee = new Employees();
                if (reader.Read())
                {
                    employee.EmpId = Convert.ToInt32(reader["EmpId"]);
                    employee.EmpName = reader["EmpName"].ToString();
                    employee.JoiningDate = Convert.ToDateTime(reader["JoiningDate"]);
                    employee.Salary = Convert.ToInt32(reader["Salary"]); 
                    employee.Dob = Convert.ToDateTime(reader["Dob"]);
                    employee.CreatedBy = Convert.ToInt32(reader["CreatedBy"]);
                    employee.CredatedOn = Convert.ToDateTime(reader["CreatedOn"]);
                    employee.IsActive = Convert.ToBoolean(reader["IsActive"]);

                }
                return Task.FromResult(employee);
            }   
        }



        //Update Employee
        public Task<Employees> UpdateEmployee(Employees employee)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString.cs))
            {
                string query = "spUpdateById";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("EmpId", employee.EmpId);
                cmd.Parameters.AddWithValue("EmpName", employee.EmpName);
                cmd.Parameters.AddWithValue("JoiningDate", employee.JoiningDate);
                cmd.Parameters.AddWithValue("Salary", employee.Salary);
                cmd.Parameters.AddWithValue("Dob", employee.Dob);
                cmd.Parameters.AddWithValue("Gender", employee.Gender);
                cmd.Parameters.AddWithValue("UpdatedBy", employee.EmpId);
                cmd.Parameters.AddWithValue("UpdatedOn", employee.UpdatedOn);
                cmd.Parameters.AddWithValue("IsActive", employee.IsActive);
                con.Open();
                cmd.ExecuteNonQuery();
                return Task.FromResult(employee);
            }
        }
    }
}
