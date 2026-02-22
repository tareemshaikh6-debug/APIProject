namespace API.Repository.Models
{
    public class Company
    {
        public int CompanyId { get; set; }
        public string? CompanyName { get; set; }

        public string? CompanyAddress { get; set; }

        public string? FounderName { get; set; }

        public int CreatedBy { get; set; } = 0;

        public DateTime CreatedOn { get; set; }

        public bool IsActive { get; set; }

        public int UpdatedBy { get; set; } = 0;
        public DateTime UpdatedOn { get; set; }
    }
}
