using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [ForeignKey("Branchs")]
        public string BranchId { get; set; }
        public ICollection<Account>? Accounts { get; set; }
        public ICollection<HelpRequest>? HelpRequests { get; set; }
        public ICollection<Service>? Services { get; set; }
    
    }
}
