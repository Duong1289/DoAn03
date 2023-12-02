using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InternetBanking.Model
{
    public class Branch
    {
        [Key]
        [Required]
        [MaxLength(5)]
        public string? BranchId { get; set; }

        [Required]
        [MaxLength(100)]
        public string? Name { get; set; }

        [Required]
        [MaxLength(150)]
        public string? Address { get; set; }

        [Required]
        [MaxLength(250)]
        public string? Location { get; set; }

        [Required]
        [MaxLength(15)]
        public string? Phone { get; set; }

        [Required]
        [MaxLength(200)]
        public string? Email { get; set; }

        [Required]
        [MaxLength(5)]
        [ForeignKey("Banks")]
        public string? BankId { get; set; }


        public ICollection<Employee>? Employees { get; set; }
    }
}
