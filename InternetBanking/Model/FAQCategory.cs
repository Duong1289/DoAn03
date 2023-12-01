using System.ComponentModel.DataAnnotations;

namespace InternetBanking.Model
{
    public class FAQCategory
    {
        [Key]
        public string? Id { get; set; }
        public string? CategoryName { get; set; }
    }
}
