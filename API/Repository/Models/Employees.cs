namespace API.Repository.Models
{
    public class Employees
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public DateTime JoiningDate { get; set; }
        public int Salary { get; set; }

        public DateTime Dob { get; set; }
        
        public string Gender { get; set; }

        public int CreatedBy { get; set; } = 0;

        public DateTime CredatedOn { get; set; }

        public int UpdatedBy { get; set; } = 0;

        public DateTime UpdatedOn { get; set; }

        public bool IsActive { get; set; }



    }
}
