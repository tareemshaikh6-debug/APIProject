namespace API.Repository.Models
{
    public class Role
    {
        public int Id { get; set; }
        public string? Rolename { get; set; }
        public string? RoleDescription { get; set; }

        public int CreatedBy { get; set; } = 0;
        public DateTime CreatedOn { get; set; }

        public DateTime UpdatedOn { get; set; } 

        public int UpdatedBy { get; set; } = 0;

        public bool IsActive { get; set; }


    }
}
