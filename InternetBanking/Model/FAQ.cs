using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InternetBanking.Model
{
    public class FAQ
    {
        [Key]
        public string? Id { get; set; }
        public string? Question { get; set; }
        public string? Answer { get; set; }
        [ForeignKey("FAQCategories")]
        public string? FAQCategoryId { get; set; }
        
    }
}
