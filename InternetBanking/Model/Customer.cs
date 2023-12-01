using System.ComponentModel.DataAnnotations;

namespace InternetBanking.Model
{
    public class Customer
    {
        [Key]
        public string? PersonalId { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public DateTime? OpenDate { get; set; }
        public string BranchId { get; set; }
    }
    }
}
