using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InternetBanking.Model
{
    public class Employee
    {
        [Key]
        [Required]
        [MaxLength(5)]
        public string? EmpId { get; set; }

        [Required]
        [MaxLength(20)]
        public string? Username { get; set; }

        [Required]
        [MaxLength(20)]
        public string? Password { get; set; }

        [Required]
        [MaxLength(50)]
        public string? FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string? LastName { get; set;}

        [Required]
        [MaxLength(15)]
        public string? Phone { get; set; }

        [Required]
        public bool? Status { get; set; }

        [Required]
        [MaxLength(5)]
        public string? RoleId { get; set; }

        [Required]
        [MaxLength(5)]
        [ForeignKey(nameof(EmpId))]
        public string? ManageBy { get; set;}

        [Required]
        [MaxLength(5)]
        [ForeignKey("Branchs")]
        public string? BranchId { get; set; }
        public ICollection<HelpRequest>? HelpRequests { get; set; }
        public ICollection<Service>? Services { get; set; }

    }
}
