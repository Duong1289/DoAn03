using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace InternetBanking.Model
{
    public class Account
    {
        [Key]
        public string? AccountNumber { get; set; }
        public double? Balance { get; set; }
        public DateTime? OpenDate { get; set; }
        public DateTime? ExpireDate { get; set;}
        public bool? Status { get; set;}
        [ForeignKey("AccountTypes")]
        public string? AccountTypeId { get; set; }
        [ForeignKey("Customers")]
        public string? CustomerPersonalId { get; set; }
        public ICollection<Service>? Services  { get; set; }
        public ICollection<Transaction>? Transactions  { get; set; }
    }
}
