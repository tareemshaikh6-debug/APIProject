
namespace API.Repository.Models
{
    public class EmpDetails
    {
        public int EmpId { get; set; }

        public string ComapnyName { get; set; } 
        public string EmpName { get; set; }
        public List<string> EmpRole { get; set; }

        public string EmpDescription { get; set; }
        public int Salary { get; set; }

       
    }
}
