using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InternetBanking.Model
{
    public class Employee
    {
        [Key]
        public string? EmpId { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set;}
        public string? Phone { get; set; }
        public bool? Status { get; set; }
        public string? RoleId { get; set; }
        [ForeignKey(nameof(EmpId))]
        public string? ManageBy { get; set;}
        [ForeignKey("Branchs")]
        public string? BranchId { get; set; }
        public ICollection<HelpRequest>? HelpRequests { get; set; }
        public ICollection<Service>? Services { get; set; }

    }
}
