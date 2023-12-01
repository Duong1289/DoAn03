using System.ComponentModel.DataAnnotations;

namespace InternetBanking.Model
{
    public class FAQ
    {
        [Key]
        public string? Id { get; set; }
        public string? Question { get; set; }
        public string? Answer { get; set; }
        public string? FAQCategoryId { get; set; }
    }
}
