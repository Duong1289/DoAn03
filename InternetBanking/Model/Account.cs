using System.ComponentModel.DataAnnotations;

namespace InternetBanking.Model
{
    public class Account
    {
        [Key]
        public string? AccountNumber { get; set; }
        public double? Balance { get; set; }
        public string? PersonalId { get; set; }
        public DateTime? OpenDate { get; set; }
        public DateTime? ExpireDate { get; set;}
        public bool? Status { get; set;}
    }
}
