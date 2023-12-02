using System.ComponentModel.DataAnnotations;

namespace InternetBanking.Model
{
    public class Bank
    {
        [Key]
        [Required]
        [MaxLength(5)]
        public string? Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string? BankName { get; set; }

        [Required]
        [MaxLength(15)]
        public string? Phone { get; set; }

        [Required]
        [MaxLength(200)]
        public string? Email { get; set; }


        [Required]
        [MaxLength(250)]
        public string? Address { get; set; }
        public ICollection<Customer>? Customers { get; set; }
        public ICollection<Employee>? Employees { get; set; }
    }
}
