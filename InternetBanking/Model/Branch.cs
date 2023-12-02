using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InternetBanking.Model
{
    public class Branch
    {
        [Key]
        public string? BranchId { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? Location { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        [ForeignKey("Banks")]
        public string? BankId { get; set; }
        public ICollection<Employee>? Employees { get; set; }
    }
}
