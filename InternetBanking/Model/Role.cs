using System.ComponentModel.DataAnnotations;

namespace InternetBanking.Model
{
    public class Role
    {
        [Key]
        [Required]
        [MaxLength(5)]
        public string? RoleId { get; set; }

        [Required]
        [MaxLength(50)]
        public string? RoleName { get; set;}
        public ICollection<Employee>? Employees { get; set; }
    }
}
