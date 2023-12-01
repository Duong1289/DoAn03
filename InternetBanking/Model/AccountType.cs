using System.ComponentModel.DataAnnotations;

namespace InternetBanking.Model
{
    public class AccountType
    {
        [Key]
        public string? Id { get; set; }
        public string? AccTypeName { get; set; }
        public string? Description { get; set; }
    }
}
