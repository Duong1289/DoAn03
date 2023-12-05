using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InternetBanking.Model
{
    public class Otp
    {
        [Key]
        [Required]
        [MaxLength(7)]
        public string? Code { get; set; }

        [Required]
        [MaxLength(20)]
        [ForeignKey("Accounts")]
        public string? AccountNumber { get; set; }

        [Required]
        [MaxLength(20)]
        [ForeignKey("Transactions")]
        public string? TransactionId {  get; set; }

        [Required]
        [DefaultValue(true)]
        public bool? Status { get; set; }

        public Transaction? Transaction { get; set; }
    }
}
