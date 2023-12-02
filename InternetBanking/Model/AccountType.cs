using System.ComponentModel.DataAnnotations;

namespace InternetBanking.Model
{
    public class AccountType
    {
        [Key]
        [Required]
        [MaxLength(5)]
        public string? Id { get; set; }


        [Required]
        [MaxLength(20)]
        public string? AccTypeName { get; set; }

        [Required]
        [MaxLength(255)]
        public string? Description { get; set; }
        public ICollection<Account>? Accounts { get; set; }
    }
}
