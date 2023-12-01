using System.ComponentModel.DataAnnotations;

namespace InternetBanking.Model
{
    public class Bank
    {
        [Key]
        public string? Id { get; set; }
        public string? BankName { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
    }
}
