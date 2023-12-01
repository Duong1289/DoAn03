using System.ComponentModel.DataAnnotations;

namespace InternetBanking.Model
{
    public class Transaction
    {
        [Key]
        public string? Id {  get; set; }
        public string? SenderAccNumber { get; set; }
        public string? ReceiverAccNumber { get; set; }
        public DateTime TransactionDate { get; set; }
        public double? Amount { get; set;}
        public string? Content { get; set;}
        public bool Validation { get; set; }

    }
}
