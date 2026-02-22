using System.Data.SqlClient;
using API.Repository.Interface;
using API.Repository.Models;

namespace API.Repository.Implementation
{
    public class EmpDetailsRepository : IEmpDetailsRepository
    {


        //Get All Details of Employee by Id
        public  Task<EmpDetails> AllDetails(int id)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString.cs))
            {
                string query = "spEmpAllDetails";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EmpId", id);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read()) {
                    EmpDetails empDetails = new EmpDetails();
                    empDetails.ComapnyName = rdr["CompanyName"].ToString();
                    empDetails.EmpId = Convert.ToInt32(rdr["EmpId"]);
                    empDetails.EmpName = rdr["EmpName"].ToString();
                    empDetails.EmpDescription = rdr["RoleDescription"].ToString();
                    empDetails.Salary = Convert.ToInt32(rdr["Salary"]);
                    string roles = rdr["Rolename"].ToString();
                    empDetails.EmpRole = roles.Split(',').ToList();
                    return Task.FromResult(empDetails);
                }
                return Task.FromResult<EmpDetails>(null);

            }
        }
    }
}
