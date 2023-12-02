using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InternetBanking.Model
{
    public class Transaction
    {
        [Key]
        public string? Id {  get; set; }
        [ForeignKey("Accounts")]
        public string? SenderAccountNumber { get; set; }
        [ForeignKey("Accounts")]
        public string? ReceiverAccountNumber { get; set; }
        public DateTime TransactionDate { get; set; }
        public double? Amount { get; set;}
        public string? Content { get; set;}
        public bool Validation { get; set; }

    }
}
